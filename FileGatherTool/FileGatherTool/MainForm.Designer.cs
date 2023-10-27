
namespace FileGatherTool
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.ceChild = new System.Windows.Forms.CheckBox();
            this.ceChooseExt = new System.Windows.Forms.CheckBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.rbRich = new System.Windows.Forms.RichTextBox();
            this.ceVideo = new System.Windows.Forms.CheckBox();
            this.ceMusic = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Path";
            // 
            // tbSource
            // 
            this.tbSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.Location = new System.Drawing.Point(135, 20);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(937, 31);
            this.tbSource.TabIndex = 3;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            // 
            // tbTarget
            // 
            this.tbTarget.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTarget.Location = new System.Drawing.Point(135, 409);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(937, 31);
            this.tbTarget.TabIndex = 4;
            this.tbTarget.TextChanged += new System.EventHandler(this.tbTarget_TextChanged);
            // 
            // btnSource
            // 
            this.btnSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSource.Location = new System.Drawing.Point(1093, 20);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 34);
            this.btnSource.TabIndex = 5;
            this.btnSource.Text = "open";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // ceChild
            // 
            this.ceChild.AutoSize = true;
            this.ceChild.Checked = true;
            this.ceChild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ceChild.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceChild.Location = new System.Drawing.Point(135, 67);
            this.ceChild.Name = "ceChild";
            this.ceChild.Size = new System.Drawing.Size(220, 28);
            this.ceChild.TabIndex = 7;
            this.ceChild.Text = "Traversing subfolders";
            this.ceChild.UseVisualStyleBackColor = true;
            // 
            // ceChooseExt
            // 
            this.ceChooseExt.AutoSize = true;
            this.ceChooseExt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceChooseExt.Location = new System.Drawing.Point(135, 210);
            this.ceChooseExt.Name = "ceChooseExt";
            this.ceChooseExt.Size = new System.Drawing.Size(375, 28);
            this.ceChooseExt.TabIndex = 8;
            this.ceChooseExt.Text = "Specify the ext name (eg: RAR,TXT,PDF)";
            this.ceChooseExt.UseVisualStyleBackColor = true;
            this.ceChooseExt.CheckedChanged += new System.EventHandler(this.ceChooseExt_CheckedChanged);
            // 
            // btnTarget
            // 
            this.btnTarget.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarget.Location = new System.Drawing.Point(1093, 404);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(75, 34);
            this.btnTarget.TabIndex = 9;
            this.btnTarget.Text = "open";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // rbRich
            // 
            this.rbRich.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRich.ForeColor = System.Drawing.Color.Red;
            this.rbRich.Location = new System.Drawing.Point(162, 259);
            this.rbRich.Name = "rbRich";
            this.rbRich.Size = new System.Drawing.Size(910, 126);
            this.rbRich.TabIndex = 10;
            this.rbRich.Text = "";
            // 
            // ceVideo
            // 
            this.ceVideo.AutoSize = true;
            this.ceVideo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceVideo.Location = new System.Drawing.Point(135, 161);
            this.ceVideo.Name = "ceVideo";
            this.ceVideo.Size = new System.Drawing.Size(125, 28);
            this.ceVideo.TabIndex = 11;
            this.ceVideo.Text = "Video files";
            this.ceVideo.UseVisualStyleBackColor = true;
            this.ceVideo.CheckedChanged += new System.EventHandler(this.ceVideo_CheckedChanged);
            // 
            // ceMusic
            // 
            this.ceMusic.AutoSize = true;
            this.ceMusic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceMusic.Location = new System.Drawing.Point(135, 114);
            this.ceMusic.Name = "ceMusic";
            this.ceMusic.Size = new System.Drawing.Size(126, 28);
            this.ceMusic.TabIndex = 12;
            this.ceMusic.Text = "Music files";
            this.ceMusic.UseVisualStyleBackColor = true;
            this.ceMusic.CheckedChanged += new System.EventHandler(this.ceMusic_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(267, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "MP3，WMA，WAV，APE，FLAC，OGG，AAC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(267, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(881, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "AVI, MP4, DAT, DVR,VCD, MOV, SVCD, VOB, DVD, DVTR, DVR, BBC, EVD, FLV, RMVB, WMV," +
    " MKV, 3GP ";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1093, 484);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 49);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCopy);
            this.groupBox1.Controls.Add(this.rbMove);
            this.groupBox1.Location = new System.Drawing.Point(135, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 62);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Checked = true;
            this.rbMove.Location = new System.Drawing.Point(6, 27);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(69, 22);
            this.rbMove.TabIndex = 0;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(102, 27);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(69, 22);
            this.rbCopy.TabIndex = 1;
            this.rbCopy.Text = "Copy";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ceMusic);
            this.Controls.Add(this.ceVideo);
            this.Controls.Add(this.rbRich);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.ceChooseExt);
            this.Controls.Add(this.ceChild);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "FileGatherTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.CheckBox ceChild;
        private System.Windows.Forms.CheckBox ceChooseExt;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.RichTextBox rbRich;
        private System.Windows.Forms.CheckBox ceVideo;
        private System.Windows.Forms.CheckBox ceMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbMove;
    }
}

