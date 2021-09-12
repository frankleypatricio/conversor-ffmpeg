
namespace Conversor.Views {
    partial class FormMessage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_messageList=new System.Windows.Forms.TextBox();
            this.lbl_title=new System.Windows.Forms.Label();
            this.icon_message=new FontAwesome.Sharp.IconPictureBox();
            this.btn_ok=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon_message)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_messageList
            // 
            this.txt_messageList.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.txt_messageList.BorderStyle=System.Windows.Forms.BorderStyle.None;
            this.txt_messageList.Font=new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_messageList.ForeColor=System.Drawing.Color.White;
            this.txt_messageList.Location=new System.Drawing.Point(12, 63);
            this.txt_messageList.Multiline=true;
            this.txt_messageList.Name="txt_messageList";
            this.txt_messageList.ReadOnly=true;
            this.txt_messageList.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
            this.txt_messageList.Size=new System.Drawing.Size(433, 246);
            this.txt_messageList.TabIndex=0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize=true;
            this.lbl_title.Font=new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.lbl_title.Location=new System.Drawing.Point(154, 21);
            this.lbl_title.Name="lbl_title";
            this.lbl_title.Size=new System.Drawing.Size(194, 22);
            this.lbl_title.TabIndex=1;
            this.lbl_title.Text="Título da mensagem";
            this.lbl_title.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_message
            // 
            this.icon_message.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.icon_message.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.icon_message.IconChar=FontAwesome.Sharp.IconChar.Exclamation;
            this.icon_message.IconColor=System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.icon_message.IconFont=FontAwesome.Sharp.IconFont.Auto;
            this.icon_message.IconSize=50;
            this.icon_message.Location=new System.Drawing.Point(12, 12);
            this.icon_message.Name="icon_message";
            this.icon_message.Size=new System.Drawing.Size(50, 50);
            this.icon_message.TabIndex=2;
            this.icon_message.TabStop=false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.btn_ok.FlatAppearance.BorderSize=0;
            this.btn_ok.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font=new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor=System.Drawing.Color.White;
            this.btn_ok.Location=new System.Drawing.Point(183, 315);
            this.btn_ok.Name="btn_ok";
            this.btn_ok.Size=new System.Drawing.Size(86, 31);
            this.btn_ok.TabIndex=3;
            this.btn_ok.Text="OK";
            this.btn_ok.UseVisualStyleBackColor=false;
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.ClientSize=new System.Drawing.Size(457, 352);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.icon_message);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_messageList);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="FormMessage";
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.icon_message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_messageList;
        private System.Windows.Forms.Label lbl_title;
        private FontAwesome.Sharp.IconPictureBox icon_message;
        private System.Windows.Forms.Button btn_ok;
    }
}