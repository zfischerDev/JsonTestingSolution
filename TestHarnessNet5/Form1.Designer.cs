
namespace TestHarnessNet5
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.jsonTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnExecuteFormatted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(32, 473);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 29);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // jsonTextBox
            // 
            this.jsonTextBox.Location = new System.Drawing.Point(41, 36);
            this.jsonTextBox.Multiline = true;
            this.jsonTextBox.Name = "jsonTextBox";
            this.jsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.jsonTextBox.Size = new System.Drawing.Size(722, 410);
            this.jsonTextBox.TabIndex = 1;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(551, 473);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(203, 29);
            this.btnSaveToFile.TabIndex = 2;
            this.btnSaveToFile.Text = "SaveToFile";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(384, 473);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(158, 29);
            this.btnDeserialize.TabIndex = 3;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnExecuteFormatted
            // 
            this.btnExecuteFormatted.Location = new System.Drawing.Point(204, 473);
            this.btnExecuteFormatted.Name = "btnExecuteFormatted";
            this.btnExecuteFormatted.Size = new System.Drawing.Size(168, 29);
            this.btnExecuteFormatted.TabIndex = 4;
            this.btnExecuteFormatted.Text = "Execute / Formatted";
            this.btnExecuteFormatted.UseVisualStyleBackColor = true;
            this.btnExecuteFormatted.Click += new System.EventHandler(this.btnExecuteFormatted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnExecuteFormatted);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.jsonTextBox);
            this.Controls.Add(this.btnExecute);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox jsonTextBox;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnExecuteFormatted;
    }
}

