﻿namespace _021_WMP
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
      ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(663, 606);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(136, 44);
      this.button1.TabIndex = 1;
      this.button1.Text = "파일 찾기";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // axWindowsMediaPlayer1
      // 
      this.axWindowsMediaPlayer1.Enabled = true;
      this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(41, 27);
      this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
      this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
      this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(461, 360);
      this.axWindowsMediaPlayer1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(823, 662);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.axWindowsMediaPlayer1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    private System.Windows.Forms.Button button1;
  }
}

