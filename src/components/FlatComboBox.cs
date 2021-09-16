using System.Drawing;
using System.Windows.Forms;

namespace Conversor.Components {
    public class FlatComboBox : ComboBox {
        private const int WM_PAINT = 0xF; //Mensagem do paint
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.Blue;

        public Color BorderColor {
            get {
                return borderColor;
            }
            set {
                borderColor=value;
                Invalidate();
            } //Invalidate() - faz com que o controle seja redesenhado
        }

        protected override void WndProc(ref Message m) { //Processa mensagens do windows
            base.WndProc(ref m);
            if(m.Msg==WM_PAINT&&DropDownStyle!=ComboBoxStyle.Simple) { //Se a mensagem enviada é o da var de paint
                using(var g = Graphics.FromHwnd(Handle)) {
                    using(var p = new Pen(BorderColor)) {
                        g.DrawRectangle(p, 0, 0, Width-1, Height-1);

                        var d = FlatStyle==FlatStyle.Popup ? 1 : 0;
                        g.DrawLine(p, Width-buttonWidth-d, 0, Width-buttonWidth-d, Height);
                    }
                }
            }
        }
    }
}
