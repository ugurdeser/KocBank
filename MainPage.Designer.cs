namespace KocBank
{
    partial class MainPage
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
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            mToolStripMenuItem = new ToolStripMenuItem();
            hesapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            vadeliİşlemlerToolStripMenuItem = new ToolStripMenuItem();
            paraYatırmaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            hesapİşlemleriToolStripMenuItem1 = new ToolStripMenuItem();
            krediKartıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            krediKartıAçılıToolStripMenuItem = new ToolStripMenuItem();
            krediKartıSilmeToolStripMenuItem = new ToolStripMenuItem();
            ödemeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            otomatikÖdemeTalimatlarıToolStripMenuItem = new ToolStripMenuItem();
            paraGöndermeToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            turuncuListeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 733);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1158, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mToolStripMenuItem, hesapİşlemleriToolStripMenuItem, krediKartıİşlemleriToolStripMenuItem, ödemeİşlemleriToolStripMenuItem, raporlarToolStripMenuItem, turuncuListeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mToolStripMenuItem
            // 
            mToolStripMenuItem.Name = "mToolStripMenuItem";
            mToolStripMenuItem.Size = new Size(106, 20);
            mToolStripMenuItem.Text = "Müşteri İşlemleri";
            mToolStripMenuItem.Click += CustomerPageToolStripMenuItem_Click;
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vadeliİşlemlerToolStripMenuItem, paraYatırmaİşlemleriToolStripMenuItem, hesapİşlemleriToolStripMenuItem1 });
            hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            hesapİşlemleriToolStripMenuItem.Size = new Size(99, 20);
            hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // vadeliİşlemlerToolStripMenuItem
            // 
            vadeliİşlemlerToolStripMenuItem.Name = "vadeliİşlemlerToolStripMenuItem";
            vadeliİşlemlerToolStripMenuItem.Size = new Size(235, 22);
            vadeliİşlemlerToolStripMenuItem.Text = "Hesap Acilis İşlemler";
            vadeliİşlemlerToolStripMenuItem.Click += vadeliİşlemlerToolStripMenuItem_Click;
            // 
            // paraYatırmaİşlemleriToolStripMenuItem
            // 
            paraYatırmaİşlemleriToolStripMenuItem.Name = "paraYatırmaİşlemleriToolStripMenuItem";
            paraYatırmaİşlemleriToolStripMenuItem.Size = new Size(235, 22);
            paraYatırmaİşlemleriToolStripMenuItem.Text = "Para Yatırma - Cekme İşlemleri";
            paraYatırmaİşlemleriToolStripMenuItem.Click += paraYatırmaİşlemleriToolStripMenuItem_Click;
            // 
            // hesapİşlemleriToolStripMenuItem1
            // 
            hesapİşlemleriToolStripMenuItem1.Name = "hesapİşlemleriToolStripMenuItem1";
            hesapİşlemleriToolStripMenuItem1.Size = new Size(235, 22);
            hesapİşlemleriToolStripMenuItem1.Text = "Hesap Kapama İşlemleri";
            hesapİşlemleriToolStripMenuItem1.Click += hesapİşlemleriToolStripMenuItem1_Click;
            // 
            // krediKartıİşlemleriToolStripMenuItem
            // 
            krediKartıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { krediKartıAçılıToolStripMenuItem, krediKartıSilmeToolStripMenuItem });
            krediKartıİşlemleriToolStripMenuItem.Name = "krediKartıİşlemleriToolStripMenuItem";
            krediKartıİşlemleriToolStripMenuItem.Size = new Size(120, 20);
            krediKartıİşlemleriToolStripMenuItem.Text = "Kredi Kartı İşlemleri";
            // 
            // krediKartıAçılıToolStripMenuItem
            // 
            krediKartıAçılıToolStripMenuItem.Name = "krediKartıAçılıToolStripMenuItem";
            krediKartıAçılıToolStripMenuItem.Size = new Size(174, 22);
            krediKartıAçılıToolStripMenuItem.Text = "Kredi Kartı Açılış";
            krediKartıAçılıToolStripMenuItem.Click += krediKartıAçılıToolStripMenuItem_Click;
            // 
            // krediKartıSilmeToolStripMenuItem
            // 
            krediKartıSilmeToolStripMenuItem.Name = "krediKartıSilmeToolStripMenuItem";
            krediKartıSilmeToolStripMenuItem.Size = new Size(174, 22);
            krediKartıSilmeToolStripMenuItem.Text = "Kredi Kartı Kapama";
            krediKartıSilmeToolStripMenuItem.Click += krediKartıSilmeToolStripMenuItem_Click;
            // 
            // ödemeİşlemleriToolStripMenuItem
            // 
            ödemeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otomatikÖdemeTalimatlarıToolStripMenuItem, paraGöndermeToolStripMenuItem });
            ödemeİşlemleriToolStripMenuItem.Name = "ödemeİşlemleriToolStripMenuItem";
            ödemeİşlemleriToolStripMenuItem.Size = new Size(105, 20);
            ödemeİşlemleriToolStripMenuItem.Text = "Ödeme İşlemleri";
            // 
            // otomatikÖdemeTalimatlarıToolStripMenuItem
            // 
            otomatikÖdemeTalimatlarıToolStripMenuItem.Name = "otomatikÖdemeTalimatlarıToolStripMenuItem";
            otomatikÖdemeTalimatlarıToolStripMenuItem.Size = new Size(223, 22);
            otomatikÖdemeTalimatlarıToolStripMenuItem.Text = "Otomatik Ödeme Talimatları";
            otomatikÖdemeTalimatlarıToolStripMenuItem.Click += otomatikÖdemeTalimatlarıToolStripMenuItem_Click;
            // 
            // paraGöndermeToolStripMenuItem
            // 
            paraGöndermeToolStripMenuItem.Name = "paraGöndermeToolStripMenuItem";
            paraGöndermeToolStripMenuItem.Size = new Size(223, 22);
            paraGöndermeToolStripMenuItem.Text = "Para Gönderme";
            paraGöndermeToolStripMenuItem.Click += paraGöndermeToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(63, 20);
            raporlarToolStripMenuItem.Text = "Raporlar";
            raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
            // 
            // turuncuListeToolStripMenuItem
            // 
            turuncuListeToolStripMenuItem.Name = "turuncuListeToolStripMenuItem";
            turuncuListeToolStripMenuItem.Size = new Size(90, 20);
            turuncuListeToolStripMenuItem.Text = "Turuncu Liste";
            turuncuListeToolStripMenuItem.Click += turuncuListeToolStripMenuItem_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainPage";
            Text = "Ana Menü";
            Load += MainPage_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mToolStripMenuItem;
        private ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem vadeliİşlemlerToolStripMenuItem;
        private ToolStripMenuItem krediKartıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem krediKartıAçılıToolStripMenuItem;
        private ToolStripMenuItem krediKartıSilmeToolStripMenuItem;
        private ToolStripMenuItem ödemeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem otomatikÖdemeTalimatlarıToolStripMenuItem;
        private ToolStripMenuItem paraGöndermeToolStripMenuItem;
        private ToolStripMenuItem paraYatırmaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem turuncuListeToolStripMenuItem;
        private ToolStripMenuItem hesapİşlemleriToolStripMenuItem1;
    }
}



