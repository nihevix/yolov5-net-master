﻿
namespace FormVideo
{

        partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblVideoDevices = new System.Windows.Forms.Label();
            this.ddlVideoDevices = new System.Windows.Forms.ComboBox();
            this.lblAzureStorageConnectionString = new System.Windows.Forms.Label();
            this.txtAzureStorageConnectionString = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recordingTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVideoDevices
            // 
            this.lblVideoDevices.AutoSize = true;
            this.lblVideoDevices.Location = new System.Drawing.Point(0, 400);
            this.lblVideoDevices.Name = "lblVideoDevices";
            this.lblVideoDevices.Size = new System.Drawing.Size(79, 15);
            this.lblVideoDevices.TabIndex = 0;
            this.lblVideoDevices.Text = "Video Source:";
            // 
            // ddlVideoDevices
            // 
            this.ddlVideoDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVideoDevices.FormattingEnabled = true;
            this.ddlVideoDevices.Location = new System.Drawing.Point(0, 415);
            this.ddlVideoDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlVideoDevices.Name = "ddlVideoDevices";
            this.ddlVideoDevices.Size = new System.Drawing.Size(712, 23);
            this.ddlVideoDevices.TabIndex = 1;
            // 
            // lblAzureStorageConnectionString
            // 
            this.lblAzureStorageConnectionString.AutoSize = true;
            this.lblAzureStorageConnectionString.Location = new System.Drawing.Point(0, 438);
            this.lblAzureStorageConnectionString.Name = "lblAzureStorageConnectionString";
            this.lblAzureStorageConnectionString.Size = new System.Drawing.Size(209, 15);
            this.lblAzureStorageConnectionString.TabIndex = 6;
            this.lblAzureStorageConnectionString.Text = "Azure Blob Storage Connection String:";
            // 
            // txtAzureStorageConnectionString
            // 
            this.txtAzureStorageConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAzureStorageConnectionString.Location = new System.Drawing.Point(0, 455);
            this.txtAzureStorageConnectionString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAzureStorageConnectionString.Name = "txtAzureStorageConnectionString";
            this.txtAzureStorageConnectionString.Size = new System.Drawing.Size(712, 23);
            this.txtAzureStorageConnectionString.TabIndex = 7;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.Location = new System.Drawing.Point(718, 410);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(108, 31);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(846, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 17);
            this.lblStatus.Text = "Strip Status Label";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // recordingTimer
            // 
            this.recordingTimer.Interval = 17;
            this.recordingTimer.Tick += new System.EventHandler(this.recordingTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtAzureStorageConnectionString);
            this.Controls.Add(this.lblAzureStorageConnectionString);
            this.Controls.Add(this.ddlVideoDevices);
            this.Controls.Add(this.lblVideoDevices);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Webcam App (Demo)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label lblVideoDevices;
            private System.Windows.Forms.ComboBox ddlVideoDevices;
            private System.Windows.Forms.Label lblAzureStorageConnectionString;
            private System.Windows.Forms.TextBox txtAzureStorageConnectionString;
            private System.Windows.Forms.Button btnRecord;
            private System.Windows.Forms.StatusStrip statusStrip;
            private System.Windows.Forms.ToolStripStatusLabel lblStatus;
            private System.Windows.Forms.PictureBox pictureBox1;
            private System.Windows.Forms.Timer recordingTimer;
            private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        }
    }