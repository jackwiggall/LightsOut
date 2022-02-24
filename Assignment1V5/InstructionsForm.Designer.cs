
namespace Assignment1V3
{
    partial class InstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.InstructionsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InstructionsTextBox
            // 
            this.InstructionsTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InstructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionsTextBox.Location = new System.Drawing.Point(40, 42);
            this.InstructionsTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.InstructionsTextBox.Name = "InstructionsTextBox";
            this.InstructionsTextBox.ReadOnly = true;
            this.InstructionsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InstructionsTextBox.Size = new System.Drawing.Size(892, 554);
            this.InstructionsTextBox.TabIndex = 0;
            this.InstructionsTextBox.Text = resources.GetString("InstructionsTextBox.Text");
            this.InstructionsTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.InstructionsTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstructionsForm";
            this.ShowIcon = false;
            this.Text = "Lights Off Instructions";
            this.Load += new System.EventHandler(this.InstructionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InstructionsTextBox;
    }
}