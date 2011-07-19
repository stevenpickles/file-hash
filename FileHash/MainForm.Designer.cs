namespace FileHash
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._SHA512HashLabel = new System.Windows.Forms.Label();
            this._SHA384HashLabel = new System.Windows.Forms.Label();
            this._SHA256HashLabel = new System.Windows.Forms.Label();
            this._SHA1HashLabel = new System.Windows.Forms.Label();
            this._RIPEMD160HashLabel = new System.Windows.Forms.Label();
            this._MD5HashLabel = new System.Windows.Forms.Label();
            this._loadFileButton = new System.Windows.Forms.Button();
            this._filePathTextBox = new System.Windows.Forms.TextBox();
            this._filenameLabel = new System.Windows.Forms.Label();
            this._MD5CheckBox = new System.Windows.Forms.CheckBox();
            this._RIPEMD160CheckBox = new System.Windows.Forms.CheckBox();
            this._SHA1CheckBox = new System.Windows.Forms.CheckBox();
            this._SHA256CheckBox = new System.Windows.Forms.CheckBox();
            this._SHA384CheckBox = new System.Windows.Forms.CheckBox();
            this._SHA512CheckBox = new System.Windows.Forms.CheckBox();
            this._calculationTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _SHA512HashLabel
            // 
            this._SHA512HashLabel.AutoSize = true;
            this._SHA512HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA512HashLabel.Location = new System.Drawing.Point( 102 , 117 );
            this._SHA512HashLabel.Name = "_SHA512HashLabel";
            this._SHA512HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA512HashLabel.TabIndex = 29;
            this._SHA512HashLabel.Text = "(blank)";
            this._SHA512HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _SHA384HashLabel
            // 
            this._SHA384HashLabel.AutoSize = true;
            this._SHA384HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA384HashLabel.Location = new System.Drawing.Point( 102 , 101 );
            this._SHA384HashLabel.Name = "_SHA384HashLabel";
            this._SHA384HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA384HashLabel.TabIndex = 27;
            this._SHA384HashLabel.Text = "(blank)";
            this._SHA384HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _SHA256HashLabel
            // 
            this._SHA256HashLabel.AutoSize = true;
            this._SHA256HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA256HashLabel.Location = new System.Drawing.Point( 102 , 85 );
            this._SHA256HashLabel.Name = "_SHA256HashLabel";
            this._SHA256HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA256HashLabel.TabIndex = 25;
            this._SHA256HashLabel.Text = "(blank)";
            this._SHA256HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _SHA1HashLabel
            // 
            this._SHA1HashLabel.AutoSize = true;
            this._SHA1HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA1HashLabel.Location = new System.Drawing.Point( 102 , 69 );
            this._SHA1HashLabel.Name = "_SHA1HashLabel";
            this._SHA1HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA1HashLabel.TabIndex = 23;
            this._SHA1HashLabel.Text = "(blank)";
            this._SHA1HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _RIPEMD160HashLabel
            // 
            this._RIPEMD160HashLabel.AutoSize = true;
            this._RIPEMD160HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._RIPEMD160HashLabel.Location = new System.Drawing.Point( 102 , 53 );
            this._RIPEMD160HashLabel.Name = "_RIPEMD160HashLabel";
            this._RIPEMD160HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._RIPEMD160HashLabel.TabIndex = 21;
            this._RIPEMD160HashLabel.Text = "(blank)";
            this._RIPEMD160HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _MD5HashLabel
            // 
            this._MD5HashLabel.AutoSize = true;
            this._MD5HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._MD5HashLabel.Location = new System.Drawing.Point( 102 , 37 );
            this._MD5HashLabel.Name = "_MD5HashLabel";
            this._MD5HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._MD5HashLabel.TabIndex = 19;
            this._MD5HashLabel.Text = "(blank)";
            this._MD5HashLabel.Click += new System.EventHandler( this.HashLabel_Click );
            // 
            // _loadFileButton
            // 
            this._loadFileButton.Location = new System.Drawing.Point( 1005 , 10 );
            this._loadFileButton.Name = "_loadFileButton";
            this._loadFileButton.Size = new System.Drawing.Size( 75 , 23 );
            this._loadFileButton.TabIndex = 17;
            this._loadFileButton.Text = "Load";
            this._loadFileButton.UseVisualStyleBackColor = true;
            this._loadFileButton.Click += new System.EventHandler( this._loadFileButton_Click );
            // 
            // _filePathTextBox
            // 
            this._filePathTextBox.Location = new System.Drawing.Point( 105 , 12 );
            this._filePathTextBox.Name = "_filePathTextBox";
            this._filePathTextBox.Size = new System.Drawing.Size( 895 , 20 );
            this._filePathTextBox.TabIndex = 16;
            // 
            // _filenameLabel
            // 
            this._filenameLabel.AutoSize = true;
            this._filenameLabel.Location = new System.Drawing.Point( 13 , 15 );
            this._filenameLabel.Name = "_filenameLabel";
            this._filenameLabel.Size = new System.Drawing.Size( 79 , 13 );
            this._filenameLabel.TabIndex = 15;
            this._filenameLabel.Text = "Path\\Filename:";
            // 
            // _MD5CheckBox
            // 
            this._MD5CheckBox.AutoSize = true;
            this._MD5CheckBox.Checked = true;
            this._MD5CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._MD5CheckBox.Location = new System.Drawing.Point( 16 , 36 );
            this._MD5CheckBox.Name = "_MD5CheckBox";
            this._MD5CheckBox.Size = new System.Drawing.Size( 52 , 17 );
            this._MD5CheckBox.TabIndex = 30;
            this._MD5CheckBox.Text = "MD5:";
            this._MD5CheckBox.UseVisualStyleBackColor = true;
            this._MD5CheckBox.CheckedChanged += new System.EventHandler( this._MD5CheckBox_CheckedChanged );
            // 
            // _RIPEMD160CheckBox
            // 
            this._RIPEMD160CheckBox.AutoSize = true;
            this._RIPEMD160CheckBox.Checked = true;
            this._RIPEMD160CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._RIPEMD160CheckBox.Location = new System.Drawing.Point( 16 , 52 );
            this._RIPEMD160CheckBox.Name = "_RIPEMD160CheckBox";
            this._RIPEMD160CheckBox.Size = new System.Drawing.Size( 89 , 17 );
            this._RIPEMD160CheckBox.TabIndex = 31;
            this._RIPEMD160CheckBox.Text = "RIPEMD160:";
            this._RIPEMD160CheckBox.UseVisualStyleBackColor = true;
            this._RIPEMD160CheckBox.CheckedChanged += new System.EventHandler( this._RIPEMD160CheckBox_CheckedChanged );
            // 
            // _SHA1CheckBox
            // 
            this._SHA1CheckBox.AutoSize = true;
            this._SHA1CheckBox.Checked = true;
            this._SHA1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._SHA1CheckBox.Location = new System.Drawing.Point( 16 , 68 );
            this._SHA1CheckBox.Name = "_SHA1CheckBox";
            this._SHA1CheckBox.Size = new System.Drawing.Size( 57 , 17 );
            this._SHA1CheckBox.TabIndex = 32;
            this._SHA1CheckBox.Text = "SHA1:";
            this._SHA1CheckBox.UseVisualStyleBackColor = true;
            this._SHA1CheckBox.CheckedChanged += new System.EventHandler( this._SHA1CheckBox_CheckedChanged );
            // 
            // _SHA256CheckBox
            // 
            this._SHA256CheckBox.AutoSize = true;
            this._SHA256CheckBox.Checked = true;
            this._SHA256CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._SHA256CheckBox.Location = new System.Drawing.Point( 16 , 84 );
            this._SHA256CheckBox.Name = "_SHA256CheckBox";
            this._SHA256CheckBox.Size = new System.Drawing.Size( 69 , 17 );
            this._SHA256CheckBox.TabIndex = 33;
            this._SHA256CheckBox.Text = "SHA256:";
            this._SHA256CheckBox.UseVisualStyleBackColor = true;
            this._SHA256CheckBox.CheckedChanged += new System.EventHandler( this._SHA256CheckBox_CheckedChanged );
            // 
            // _SHA384CheckBox
            // 
            this._SHA384CheckBox.AutoSize = true;
            this._SHA384CheckBox.Checked = true;
            this._SHA384CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._SHA384CheckBox.Location = new System.Drawing.Point( 16 , 100 );
            this._SHA384CheckBox.Name = "_SHA384CheckBox";
            this._SHA384CheckBox.Size = new System.Drawing.Size( 69 , 17 );
            this._SHA384CheckBox.TabIndex = 34;
            this._SHA384CheckBox.Text = "SHA384:";
            this._SHA384CheckBox.UseVisualStyleBackColor = true;
            this._SHA384CheckBox.CheckedChanged += new System.EventHandler( this._SHA384CheckBox_CheckedChanged );
            // 
            // _SHA512CheckBox
            // 
            this._SHA512CheckBox.AutoSize = true;
            this._SHA512CheckBox.Checked = true;
            this._SHA512CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._SHA512CheckBox.Location = new System.Drawing.Point( 16 , 116 );
            this._SHA512CheckBox.Name = "_SHA512CheckBox";
            this._SHA512CheckBox.Size = new System.Drawing.Size( 69 , 17 );
            this._SHA512CheckBox.TabIndex = 35;
            this._SHA512CheckBox.Text = "SHA512:";
            this._SHA512CheckBox.UseVisualStyleBackColor = true;
            this._SHA512CheckBox.CheckedChanged += new System.EventHandler( this._SHA512CheckBox_CheckedChanged );
            // 
            // _calculationTimeLabel
            // 
            this._calculationTimeLabel.AutoSize = true;
            this._calculationTimeLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._calculationTimeLabel.Location = new System.Drawing.Point( 102 , 133 );
            this._calculationTimeLabel.Name = "_calculationTimeLabel";
            this._calculationTimeLabel.Size = new System.Drawing.Size( 168 , 14 );
            this._calculationTimeLabel.TabIndex = 36;
            this._calculationTimeLabel.Text = "calculation time = ? ms";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1092 , 156 );
            this.Controls.Add( this._calculationTimeLabel );
            this.Controls.Add( this._SHA512CheckBox );
            this.Controls.Add( this._SHA384CheckBox );
            this.Controls.Add( this._SHA256CheckBox );
            this.Controls.Add( this._SHA1CheckBox );
            this.Controls.Add( this._RIPEMD160CheckBox );
            this.Controls.Add( this._MD5CheckBox );
            this.Controls.Add( this._SHA512HashLabel );
            this.Controls.Add( this._SHA384HashLabel );
            this.Controls.Add( this._SHA256HashLabel );
            this.Controls.Add( this._SHA1HashLabel );
            this.Controls.Add( this._RIPEMD160HashLabel );
            this.Controls.Add( this._MD5HashLabel );
            this.Controls.Add( this._loadFileButton );
            this.Controls.Add( this._filePathTextBox );
            this.Controls.Add( this._filenameLabel );
            this.Name = "MainForm";
            this.Text = "Hash Generator/Checker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler( this.MainForm_DragDrop );
            this.DragEnter += new System.Windows.Forms.DragEventHandler( this.MainForm_DragEnter );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _SHA512HashLabel;
        private System.Windows.Forms.Label _SHA384HashLabel;
        private System.Windows.Forms.Label _SHA256HashLabel;
        private System.Windows.Forms.Label _SHA1HashLabel;
        private System.Windows.Forms.Label _RIPEMD160HashLabel;
        private System.Windows.Forms.Label _MD5HashLabel;
        private System.Windows.Forms.Button _loadFileButton;
        private System.Windows.Forms.TextBox _filePathTextBox;
        private System.Windows.Forms.Label _filenameLabel;
        private System.Windows.Forms.CheckBox _MD5CheckBox;
        private System.Windows.Forms.CheckBox _RIPEMD160CheckBox;
        private System.Windows.Forms.CheckBox _SHA1CheckBox;
        private System.Windows.Forms.CheckBox _SHA256CheckBox;
        private System.Windows.Forms.CheckBox _SHA384CheckBox;
        private System.Windows.Forms.CheckBox _SHA512CheckBox;
        private System.Windows.Forms.Label _calculationTimeLabel;
    }
}

