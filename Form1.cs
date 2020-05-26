using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Modules;
using Tangine;

namespace PosWalker {
    [Module("PosWalker", "lorem ipsum dot color amet")]
    [Author("0x001", HabboName = "0x001", Hotel = HHotel.ComBr, ResourceName = "", ResourceUrl = ""),
     Author("!Chaos", HabboName = "!Chaos", Hotel = HHotel.ComBr, ResourceName = "", ResourceUrl = "")]
    public partial class Form1 : ExtensionForm {

        private IKeyboardMouseEvents m_GlobalHook;
        private HPoint tile1, tile2, currentPosition;
        private int userIndex, packets_to_send = 1;
        
        public Form1() {
            InitializeComponent();
            Triggers.InAttach(In.RoomHeightMap, OnNewRoom);
            Triggers.InAttach(In.RoomUserStatus, OnUserStatusChanged);

            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (tile1 == null || tile2 == null) return;
            HPoint destination;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    destination = tile1;
                    break;
                case Keys.Right:
                    destination = tile2;
                    break;
                default:
                    return;
            }

            for (var i = 0; i < packets_to_send; i++) {
                Connection.SendToServerAsync(Out.RoomUserWalk, destination.X, destination.Y);
            }
        }

        private void OnUserStatusChanged(DataInterceptedEventArgs e) {         
            var updates = HEntityUpdate.Parse(e.Packet);
            Task.Run(() => {
                foreach (var update in updates) {
                    if (update.Index != userIndex || update.MovingTo == null) return;
                    currentPosition = new HPoint(update.MovingTo.X, update.MovingTo.Y);
                }
            }, new CancellationToken());            
        }

        private void OnNewRoom(DataInterceptedEventArgs e) {
            Task.Run(() => {
                userIndex = -1;
                GetUserIndex();
            }, new CancellationToken());
        }

        private void BtnSetLeftPos_Click(object sender, EventArgs e) {
            if (currentPosition == null) return;
            tile1 = currentPosition;
            txtLeftPos.Text = tile1.ToString();
        }

        private void ChkbTopMost_CheckStateChanged(object sender, EventArgs e) {
            this.TopMost = chkbTopMost.Checked;
        }

        private void BtnSetNoPacketsToSent_Click(object sender, EventArgs e) {
            this.packets_to_send = (int) upDownPacketsToSent.Value;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void BtnSetRightPos_Click(object sender, EventArgs e) {
            if (currentPosition == null) return;
            tile2 = currentPosition;
            txtRightPos.Text = tile2.ToString();
        }

        private async void GetUserIndex() {
            Triggers.InAttach(In.RoomUserWhisper, OnWhisper);
            await Connection.SendToServerAsync(Out.RoomUserWhisper, "[!] Identificando índice...", 0);
        }   

        private async void OnWhisper(DataInterceptedEventArgs e) {
            userIndex = e.Packet.ReadInteger();
            Triggers.InDetach(In.RoomUserWhisper);
            
            await Task.Delay(500);
            await Connection.SendToServerAsync(Out.RoomUserWhisper, "[!] Pronto.", 0);
        }

    }
}
