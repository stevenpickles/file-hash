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
            this._SHA512Label = new System.Windows.Forms.Label();
            this._SHA384HashLabel = new System.Windows.Forms.Label();
            this._SHA384Label = new System.Windows.Forms.Label();
            this._SHA256HashLabel = new System.Windows.Forms.Label();
            this._SHA256Label = new System.Windows.Forms.Label();
            this._SHA1HashLabel = new System.Windows.Forms.Label();
            this._SHA1Label = new System.Windows.Forms.Label();
            this._RIPEMD160HashLabel = new System.Windows.Forms.Label();
            this._RIPEMD160Label = new System.Windows.Forms.Label();
            this._MD5HashLabel = new System.Windows.Forms.Label();
            this._MD5Label = new System.Windows.Forms.Label();
            this._loadFileButton = new System.Windows.Forms.Button();
            this._filePathTextBox = new System.Windows.Forms.TextBox();
            this._filenameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _SHA512HashLabel
            // 
            this._SHA512HashLabel.AutoSize = true;
            this._SHA512HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA512HashLabel.Location = new System.Drawing.Point( 96 , 102 );
            this._SHA512HashLabel.Name = "_SHA512HashLabel";
            this._SHA512HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA512HashLabel.TabIndex = 29;
            this._SHA512HashLabel.Text = "(blank)";
            // 
            // _SHA512Label
            // 
            this._SHA512Label.AutoSize = true;
            this._SHA512Label.Location = new System.Drawing.Point( 13 , 102 );
            this._SHA512Label.Name = "_SHA512Label";
            this._SHA512Label.Size = new System.Drawing.Size( 53 , 13 );
            this._SHA512Label.TabIndex = 28;
            this._SHA512Label.Text = "SHA-512:";
            // 
            // _SHA384HashLabel
            // 
            this._SHA384HashLabel.AutoSize = true;
            this._SHA384HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA384HashLabel.Location = new System.Drawing.Point( 96 , 89 );
            this._SHA384HashLabel.Name = "_SHA384HashLabel";
            this._SHA384HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA384HashLabel.TabIndex = 27;
            this._SHA384HashLabel.Text = "(blank)";
            // 
            // _SHA384Label
            // 
            this._SHA384Label.AutoSize = true;
            this._SHA384Label.Location = new System.Drawing.Point( 13 , 89 );
            this._SHA384Label.Name = "_SHA384Label";
            this._SHA384Label.Size = new System.Drawing.Size( 53 , 13 );
            this._SHA384Label.TabIndex = 26;
            this._SHA384Label.Text = "SHA-384:";
            // 
            // _SHA256HashLabel
            // 
            this._SHA256HashLabel.AutoSize = true;
            this._SHA256HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA256HashLabel.Location = new System.Drawing.Point( 96 , 76 );
            this._SHA256HashLabel.Name = "_SHA256HashLabel";
            this._SHA256HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA256HashLabel.TabIndex = 25;
            this._SHA256HashLabel.Text = "(blank)";
            // 
            // _SHA256Label
            // 
            this._SHA256Label.AutoSize = true;
            this._SHA256Label.Location = new System.Drawing.Point( 13 , 76 );
            this._SHA256Label.Name = "_SHA256Label";
            this._SHA256Label.Size = new System.Drawing.Size( 53 , 13 );
            this._SHA256Label.TabIndex = 24;
            this._SHA256Label.Text = "SHA-256:";
            // 
            // _SHA1HashLabel
            // 
            this._SHA1HashLabel.AutoSize = true;
            this._SHA1HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._SHA1HashLabel.Location = new System.Drawing.Point( 96 , 63 );
            this._SHA1HashLabel.Name = "_SHA1HashLabel";
            this._SHA1HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._SHA1HashLabel.TabIndex = 23;
            this._SHA1HashLabel.Text = "(blank)";
            // 
            // _SHA1Label
            // 
            this._SHA1Label.AutoSize = true;
            this._SHA1Label.Location = new System.Drawing.Point( 13 , 63 );
            this._SHA1Label.Name = "_SHA1Label";
            this._SHA1Label.Size = new System.Drawing.Size( 41 , 13 );
            this._SHA1Label.TabIndex = 22;
            this._SHA1Label.Text = "SHA-1:";
            // 
            // _RIPEMD160HashLabel
            // 
            this._RIPEMD160HashLabel.AutoSize = true;
            this._RIPEMD160HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._RIPEMD160HashLabel.Location = new System.Drawing.Point( 96 , 50 );
            this._RIPEMD160HashLabel.Name = "_RIPEMD160HashLabel";
            this._RIPEMD160HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._RIPEMD160HashLabel.TabIndex = 21;
            this._RIPEMD160HashLabel.Text = "(blank)";
            // 
            // _RIPEMD160Label
            // 
            this._RIPEMD160Label.AutoSize = true;
            this._RIPEMD160Label.Location = new System.Drawing.Point( 13 , 50 );
            this._RIPEMD160Label.Name = "_RIPEMD160Label";
            this._RIPEMD160Label.Size = new System.Drawing.Size( 70 , 13 );
            this._RIPEMD160Label.TabIndex = 20;
            this._RIPEMD160Label.Text = "RIPEMD160:";
            // 
            // _MD5HashLabel
            // 
            this._MD5HashLabel.AutoSize = true;
            this._MD5HashLabel.Font = new System.Drawing.Font( "Courier New" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( ( byte ) ( 0 ) ) );
            this._MD5HashLabel.Location = new System.Drawing.Point( 96 , 37 );
            this._MD5HashLabel.Name = "_MD5HashLabel";
            this._MD5HashLabel.Size = new System.Drawing.Size( 56 , 14 );
            this._MD5HashLabel.TabIndex = 19;
            this._MD5HashLabel.Text = "(blank)";
            // 
            // _MD5Label
            // 
            this._MD5Label.AutoSize = true;
            this._MD5Label.Location = new System.Drawing.Point( 13 , 37 );
            this._MD5Label.Name = "_MD5Label";
            this._MD5Label.Size = new System.Drawing.Size( 33 , 13 );
            this._MD5Label.TabIndex = 18;
            this._MD5Label.Text = "MD5:";
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
            this._filePathTextBox.Location = new System.Drawing.Point( 98 , 12 );
            this._filePathTextBox.Name = "_filePathTextBox";
            this._filePathTextBox.Size = new System.Drawing.Size( 901 , 20 );
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
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1092 , 126 );
            this.Controls.Add( this._SHA512HashLabel );
            this.Controls.Add( this._SHA512Label );
            this.Controls.Add( this._SHA384HashLabel );
            this.Controls.Add( this._SHA384Label );
            this.Controls.Add( this._SHA256HashLabel );
            this.Controls.Add( this._SHA256Label );
            this.Controls.Add( this._SHA1HashLabel );
            this.Controls.Add( this._SHA1Label );
            this.Controls.Add( this._RIPEMD160HashLabel );
            this.Controls.Add( this._RIPEMD160Label );
            this.Controls.Add( this._MD5HashLabel );
            this.Controls.Add( this._MD5Label );
            this.Controls.Add( this._loadFileButton );
            this.Controls.Add( this._filePathTextBox );
            this.Controls.Add( this._filenameLabel );
            this.Name = "MainForm";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler( this.MainForm_DragDrop );
            this.DragEnter += new System.Windows.Forms.DragEventHandler( this.MainForm_DragEnter );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _SHA512HashLabel;
        private System.Windows.Forms.Label _SHA512Label;
        private System.Windows.Forms.Label _SHA384HashLabel;
        private System.Windows.Forms.Label _SHA384Label;
        private System.Windows.Forms.Label _SHA256HashLabel;
        private System.Windows.Forms.Label _SHA256Label;
        private System.Windows.Forms.Label _SHA1HashLabel;
        private System.Windows.Forms.Label _SHA1Label;
        private System.Windows.Forms.Label _RIPEMD160HashLabel;
        private System.Windows.Forms.Label _RIPEMD160Label;
        private System.Windows.Forms.Label _MD5HashLabel;
        private System.Windows.Forms.Label _MD5Label;
        private System.Windows.Forms.Button _loadFileButton;
        private System.Windows.Forms.TextBox _filePathTextBox;
        private System.Windows.Forms.Label _filenameLabel;
    }
}

