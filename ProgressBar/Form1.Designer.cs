﻿namespace ProgressBar
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(12, 12);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(312, 39);
            this.pbStatus.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRun.Location = new System.Drawing.Point(12, 57);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(167, 94);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "실행";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(185, 57);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(138, 44);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "멈춤";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(185, 107);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "리셋";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(12, 154);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "상태 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 190);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "상태진행";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer Timer;
    }
}

