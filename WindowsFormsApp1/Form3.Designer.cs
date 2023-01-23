
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbllocation = new System.Windows.Forms.Label();
            this.txtManId = new System.Windows.Forms.TextBox();
            this.txtManName = new System.Windows.Forms.TextBox();
            this.txtManLocation = new System.Windows.Forms.TextBox();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.btnBinaryReader = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(119, 94);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(61, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Manager Id";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(119, 134);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(80, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Manager Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Location = new System.Drawing.Point(119, 178);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(93, 13);
            this.lbllocation.TabIndex = 2;
            this.lbllocation.Text = "Manager Location";
            // 
            // txtManId
            // 
            this.txtManId.Location = new System.Drawing.Point(244, 87);
            this.txtManId.Name = "txtManId";
            this.txtManId.Size = new System.Drawing.Size(100, 20);
            this.txtManId.TabIndex = 3;
            this.txtManId.TextChanged += new System.EventHandler(this.txtManId_TextChanged);
            // 
            // txtManName
            // 
            this.txtManName.Location = new System.Drawing.Point(244, 134);
            this.txtManName.Name = "txtManName";
            this.txtManName.Size = new System.Drawing.Size(100, 20);
            this.txtManName.TabIndex = 4;
            // 
            // txtManLocation
            // 
            this.txtManLocation.Location = new System.Drawing.Point(244, 178);
            this.txtManLocation.Name = "txtManLocation";
            this.txtManLocation.Size = new System.Drawing.Size(100, 20);
            this.txtManLocation.TabIndex = 5;
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Location = new System.Drawing.Point(226, 236);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWriter.TabIndex = 6;
            this.btnBinaryWriter.Text = "Binary Writer";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // btnBinaryReader
            // 
            this.btnBinaryReader.Location = new System.Drawing.Point(340, 236);
            this.btnBinaryReader.Name = "btnBinaryReader";
            this.btnBinaryReader.Size = new System.Drawing.Size(97, 23);
            this.btnBinaryReader.TabIndex = 7;
            this.btnBinaryReader.Text = "Binary Reader";
            this.btnBinaryReader.UseVisualStyleBackColor = true;
            this.btnBinaryReader.Click += new System.EventHandler(this.btnBinaryReader_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(427, 94);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(89, 23);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(534, 94);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnBinaryReader);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.txtManLocation);
            this.Controls.Add(this.txtManName);
            this.Controls.Add(this.txtManId);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.TextBox txtManId;
        private System.Windows.Forms.TextBox txtManName;
        private System.Windows.Forms.TextBox txtManLocation;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnBinaryReader;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
    }
}