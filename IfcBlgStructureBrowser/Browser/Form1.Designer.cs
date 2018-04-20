namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonOpen = new System.Windows.Forms.Button();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonOpen
            // 
            this._buttonOpen.Location = new System.Drawing.Point(12, 12);
            this._buttonOpen.Name = "_buttonOpen";
            this._buttonOpen.Size = new System.Drawing.Size(75, 23);
            this._buttonOpen.TabIndex = 0;
            this._buttonOpen.Text = "Open IfcXML ...";
            this._buttonOpen.UseVisualStyleBackColor = true;
            this._buttonOpen.Click += new System.EventHandler(this._buttonOpen_Click);
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(103, 12);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(386, 363);
            this._richTextBox.TabIndex = 1;
            this._richTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOpen;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.Button button1;
    }
}

