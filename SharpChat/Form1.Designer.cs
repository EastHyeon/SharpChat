namespace SharpChat
{
    partial class SharpChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msgButton = new Button();
            mainMsgBox = new RichTextBox();
            msgInputBox = new TextBox();
            nameBox = new TextBox();
            changeButton = new Button();
            SuspendLayout();
            // 
            // msgButton
            // 
            msgButton.Location = new Point(263, 377);
            msgButton.Name = "msgButton";
            msgButton.Size = new Size(75, 23);
            msgButton.TabIndex = 1;
            msgButton.Text = "전송";
            msgButton.UseVisualStyleBackColor = true;
            msgButton.Click += button1_Click;
            // 
            // mainMsgBox
            // 
            mainMsgBox.BackColor = Color.Black;
            mainMsgBox.BorderStyle = BorderStyle.None;
            mainMsgBox.ForeColor = Color.White;
            mainMsgBox.Location = new Point(12, 0);
            mainMsgBox.Name = "mainMsgBox";
            mainMsgBox.ReadOnly = true;
            mainMsgBox.ScrollBars = RichTextBoxScrollBars.Horizontal;
            mainMsgBox.Size = new Size(326, 389);
            mainMsgBox.TabIndex = 0;
            mainMsgBox.Text = "";
            mainMsgBox.KeyDown += Form1_KeyDown;
            // 
            // msgInputBox
            // 
            msgInputBox.Location = new Point(12, 378);
            msgInputBox.Name = "msgInputBox";
            msgInputBox.PlaceholderText = "아무말 대잔치 ㄱㄱ";
            msgInputBox.Size = new Size(245, 23);
            msgInputBox.TabIndex = 2;
            msgInputBox.TextChanged += msgInputBox_TextChanged;
            msgInputBox.KeyDown += Form1_KeyDown;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 408);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "닉네임 입력";
            nameBox.Size = new Size(89, 23);
            nameBox.TabIndex = 3;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(107, 407);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(75, 23);
            changeButton.TabIndex = 4;
            changeButton.Text = "변경";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // SharpChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(350, 450);
            Controls.Add(changeButton);
            Controls.Add(nameBox);
            Controls.Add(msgInputBox);
            Controls.Add(mainMsgBox);
            Controls.Add(msgButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SharpChat";
            Text = "SharpChat";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button msgButton;
        private RichTextBox mainMsgBox;
        private TextBox msgInputBox;
        private TextBox nameBox;
        private Button changeButton;
    }
}
