namespace VLCLibTest
{
    partial class mainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_renderWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_renderWindow
            // 
            this.panel_renderWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_renderWindow.Location = new System.Drawing.Point(42, 42);
            this.panel_renderWindow.Name = "panel_renderWindow";
            this.panel_renderWindow.Size = new System.Drawing.Size(611, 345);
            this.panel_renderWindow.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_renderWindow);
            this.Name = "mainWindow";
            this.Text = "VLCLib播放器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_renderWindow;
    }
}

