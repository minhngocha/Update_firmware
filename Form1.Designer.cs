namespace Update_firmware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chb_update = new System.Windows.Forms.CheckBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.grB1 = new System.Windows.Forms.GroupBox();
            this.grB2 = new System.Windows.Forms.GroupBox();
            this.txt_firm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtxt_data = new System.Windows.Forms.RichTextBox();
            this.grB1.SuspendLayout();
            this.grB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb_update
            // 
            this.chb_update.AutoSize = true;
            this.chb_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_update.Location = new System.Drawing.Point(239, 30);
            this.chb_update.Margin = new System.Windows.Forms.Padding(4);
            this.chb_update.Name = "chb_update";
            this.chb_update.Size = new System.Drawing.Size(135, 24);
            this.chb_update.TabIndex = 0;
            this.chb_update.Text = "Enable Update";
            this.chb_update.UseVisualStyleBackColor = true;
            // 
            // btn_listen
            // 
            this.btn_listen.AutoSize = true;
            this.btn_listen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_listen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listen.Location = new System.Drawing.Point(148, 43);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(75, 34);
            this.btn_listen.TabIndex = 1;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.Btn_listen_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.AutoSize = true;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stop.Enabled = false;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Location = new System.Drawing.Point(249, 43);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(96, 34);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop Server";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listen on port";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(9, 53);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 24);
            this.txt_port.TabIndex = 4;
            // 
            // grB1
            // 
            this.grB1.Controls.Add(this.btn_stop);
            this.grB1.Controls.Add(this.txt_port);
            this.grB1.Controls.Add(this.btn_listen);
            this.grB1.Controls.Add(this.label1);
            this.grB1.Location = new System.Drawing.Point(5, 5);
            this.grB1.Name = "grB1";
            this.grB1.Size = new System.Drawing.Size(390, 89);
            this.grB1.TabIndex = 5;
            this.grB1.TabStop = false;
            this.grB1.Text = "Setting";
            // 
            // grB2
            // 
            this.grB2.Controls.Add(this.txt_firm);
            this.grB2.Controls.Add(this.label2);
            this.grB2.Controls.Add(this.chb_update);
            this.grB2.Enabled = false;
            this.grB2.Location = new System.Drawing.Point(9, 100);
            this.grB2.Name = "grB2";
            this.grB2.Size = new System.Drawing.Size(381, 101);
            this.grB2.TabIndex = 6;
            this.grB2.TabStop = false;
            this.grB2.Text = "Update Firmware";
            // 
            // txt_firm
            // 
            this.txt_firm.Location = new System.Drawing.Point(10, 61);
            this.txt_firm.Name = "txt_firm";
            this.txt_firm.Size = new System.Drawing.Size(100, 24);
            this.txt_firm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Firmware";
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(9, 594);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 34);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // rtxt_data
            // 
            this.rtxt_data.Location = new System.Drawing.Point(5, 212);
            this.rtxt_data.Name = "rtxt_data";
            this.rtxt_data.Size = new System.Drawing.Size(390, 376);
            this.rtxt_data.TabIndex = 9;
            this.rtxt_data.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(402, 634);
            this.Controls.Add(this.rtxt_data);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.grB2);
            this.Controls.Add(this.grB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPA_TEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grB1.ResumeLayout(false);
            this.grB1.PerformLayout();
            this.grB2.ResumeLayout(false);
            this.grB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_update;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.GroupBox grB1;
        private System.Windows.Forms.GroupBox grB2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox rtxt_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firm;
    }
}

