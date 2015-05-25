namespace MyEndcodeDecode
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
            this.TB_in = new System.Windows.Forms.RichTextBox();
            this.TB_out = new System.Windows.Forms.RichTextBox();
            this.BT_endcode = new System.Windows.Forms.Button();
            this.BT_decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_in
            // 
            this.TB_in.Location = new System.Drawing.Point(2, 3);
            this.TB_in.Name = "TB_in";
            this.TB_in.Size = new System.Drawing.Size(659, 96);
            this.TB_in.TabIndex = 0;
            this.TB_in.Text = "";
            // 
            // TB_out
            // 
            this.TB_out.Location = new System.Drawing.Point(2, 242);
            this.TB_out.Name = "TB_out";
            this.TB_out.Size = new System.Drawing.Size(659, 96);
            this.TB_out.TabIndex = 1;
            this.TB_out.Text = "";
            // 
            // BT_endcode
            // 
            this.BT_endcode.Location = new System.Drawing.Point(51, 142);
            this.BT_endcode.Name = "BT_endcode";
            this.BT_endcode.Size = new System.Drawing.Size(71, 43);
            this.BT_endcode.TabIndex = 2;
            this.BT_endcode.Text = "EndCode";
            this.BT_endcode.UseVisualStyleBackColor = true;
            this.BT_endcode.Click += new System.EventHandler(this.BT_endcode_Click);
            // 
            // BT_decode
            // 
            this.BT_decode.Location = new System.Drawing.Point(166, 142);
            this.BT_decode.Name = "BT_decode";
            this.BT_decode.Size = new System.Drawing.Size(71, 43);
            this.BT_decode.TabIndex = 3;
            this.BT_decode.Text = "Decode";
            this.BT_decode.UseVisualStyleBackColor = true;
            this.BT_decode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BT_decode_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 358);
            this.Controls.Add(this.BT_decode);
            this.Controls.Add(this.BT_endcode);
            this.Controls.Add(this.TB_out);
            this.Controls.Add(this.TB_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TB_in;
        private System.Windows.Forms.RichTextBox TB_out;
        private System.Windows.Forms.Button BT_endcode;
        private System.Windows.Forms.Button BT_decode;
    }
}

