﻿namespace PoEWhisperNotifier {
	partial class ConfigureSmtpDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			this.propSettings = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// propSettings
			// 
			this.propSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propSettings.Location = new System.Drawing.Point(16, 15);
			this.propSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.propSettings.Name = "propSettings";
			this.propSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.propSettings.Size = new System.Drawing.Size(1105, 636);
			this.propSettings.TabIndex = 0;
			// 
			// ConfigureSmtpDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 666);
			this.Controls.Add(this.propSettings);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ConfigureSmtpDialog";
			this.Text = "Configure Smtp";
			this.Load += new System.EventHandler(this.ConfigureSmtpDialog_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid propSettings;
	}
}