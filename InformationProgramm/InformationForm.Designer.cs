
namespace InformationProgramm
{
    partial class InformationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InformationLb = new System.Windows.Forms.ListBox();
            this.MoreInformationLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // InformationLb
            // 
            this.InformationLb.FormattingEnabled = true;
            this.InformationLb.ItemHeight = 16;
            this.InformationLb.Location = new System.Drawing.Point(13, 34);
            this.InformationLb.Name = "InformationLb";
            this.InformationLb.Size = new System.Drawing.Size(270, 436);
            this.InformationLb.TabIndex = 0;
            this.InformationLb.SelectedIndexChanged += new System.EventHandler(this.InformationLb_SelectedIndexChanged);
            // 
            // MoreInformationLb
            // 
            this.MoreInformationLb.FormattingEnabled = true;
            this.MoreInformationLb.ItemHeight = 16;
            this.MoreInformationLb.Location = new System.Drawing.Point(392, 34);
            this.MoreInformationLb.Name = "MoreInformationLb";
            this.MoreInformationLb.Size = new System.Drawing.Size(270, 436);
            this.MoreInformationLb.TabIndex = 1;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 501);
            this.Controls.Add(this.MoreInformationLb);
            this.Controls.Add(this.InformationLb);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InformationLb;
        private System.Windows.Forms.ListBox MoreInformationLb;
    }
}

