namespace obiskonya
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AnaSayfaPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.adminbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.islemlerpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.otoparklistelebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kayitpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.adsoyadbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.geribtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgiris = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitolbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mailbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.girisyapbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgirissifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.destekbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.girisbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnaSayfaUstPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.AnaSayfaPanel.SuspendLayout();
            this.kayitpanel.SuspendLayout();
            this.AnaSayfaUstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AnaSayfaPanel
            // 
            this.AnaSayfaPanel.BackColor = System.Drawing.Color.Yellow;
            this.AnaSayfaPanel.BackgroundImage = global::obiskonya.Properties.Resources.panel1son;
            this.AnaSayfaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnaSayfaPanel.Controls.Add(this.adminbuton);
            this.AnaSayfaPanel.Controls.Add(this.islemlerpanel);
            this.AnaSayfaPanel.Controls.Add(this.otoparklistelebtn);
            this.AnaSayfaPanel.Controls.Add(this.kayitpanel);
            this.AnaSayfaPanel.Controls.Add(this.destekbtn);
            this.AnaSayfaPanel.Controls.Add(this.girisbtn);
            this.AnaSayfaPanel.Controls.Add(this.AnaSayfaUstPanel);
            this.AnaSayfaPanel.Location = new System.Drawing.Point(-59, -30);
            this.AnaSayfaPanel.Name = "AnaSayfaPanel";
            this.AnaSayfaPanel.ShadowDecoration.Parent = this.AnaSayfaPanel;
            this.AnaSayfaPanel.Size = new System.Drawing.Size(1280, 718);
            this.AnaSayfaPanel.TabIndex = 0;
            this.AnaSayfaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            this.AnaSayfaPanel.MouseEnter += new System.EventHandler(this.AnaSayfaPanel_MouseEnter);
            // 
            // adminbuton
            // 
            this.adminbuton.Animated = true;
            this.adminbuton.AutoRoundedCorners = true;
            this.adminbuton.BackColor = System.Drawing.Color.Transparent;
            this.adminbuton.BorderRadius = 21;
            this.adminbuton.CheckedState.Parent = this.adminbuton;
            this.adminbuton.CustomImages.Parent = this.adminbuton;
            this.adminbuton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adminbuton.FillColor2 = System.Drawing.Color.Black;
            this.adminbuton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminbuton.ForeColor = System.Drawing.Color.White;
            this.adminbuton.HoverState.Parent = this.adminbuton;
            this.adminbuton.Location = new System.Drawing.Point(355, 114);
            this.adminbuton.Name = "adminbuton";
            this.adminbuton.ShadowDecoration.Parent = this.adminbuton;
            this.adminbuton.Size = new System.Drawing.Size(125, 45);
            this.adminbuton.TabIndex = 17;
            this.adminbuton.Text = "Admin";
            this.adminbuton.UseTransparentBackground = true;
            this.adminbuton.Click += new System.EventHandler(this.adminbuton_Click);
            // 
            // islemlerpanel
            // 
            this.islemlerpanel.BackColor = System.Drawing.Color.Transparent;
            this.islemlerpanel.Location = new System.Drawing.Point(97, 165);
            this.islemlerpanel.Name = "islemlerpanel";
            this.islemlerpanel.ShadowDecoration.Parent = this.islemlerpanel;
            this.islemlerpanel.Size = new System.Drawing.Size(1097, 464);
            this.islemlerpanel.TabIndex = 16;
            this.islemlerpanel.Visible = false;
            this.islemlerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.islemlerpanel_Paint);
            // 
            // otoparklistelebtn
            // 
            this.otoparklistelebtn.Animated = true;
            this.otoparklistelebtn.AutoRoundedCorners = true;
            this.otoparklistelebtn.BackColor = System.Drawing.Color.Transparent;
            this.otoparklistelebtn.BorderRadius = 21;
            this.otoparklistelebtn.CheckedState.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.CustomImages.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.otoparklistelebtn.FillColor2 = System.Drawing.Color.Black;
            this.otoparklistelebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otoparklistelebtn.ForeColor = System.Drawing.Color.White;
            this.otoparklistelebtn.HoverState.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.Location = new System.Drawing.Point(71, 114);
            this.otoparklistelebtn.Name = "otoparklistelebtn";
            this.otoparklistelebtn.ShadowDecoration.Parent = this.otoparklistelebtn;
            this.otoparklistelebtn.Size = new System.Drawing.Size(125, 45);
            this.otoparklistelebtn.TabIndex = 15;
            this.otoparklistelebtn.Text = "Otopark Durumları";
            this.otoparklistelebtn.UseTransparentBackground = true;
            this.otoparklistelebtn.Click += new System.EventHandler(this.otoparklistelebtn_Click);
            // 
            // kayitpanel
            // 
            this.kayitpanel.BackColor = System.Drawing.Color.Transparent;
            this.kayitpanel.BackgroundImage = global::obiskonya.Properties.Resources.giriskayitpanel;
            this.kayitpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kayitpanel.Controls.Add(this.adsoyadbox);
            this.kayitpanel.Controls.Add(this.geribtn);
            this.kayitpanel.Controls.Add(this.txtgiris);
            this.kayitpanel.Controls.Add(this.kayitolbtn);
            this.kayitpanel.Controls.Add(this.mailbox);
            this.kayitpanel.Controls.Add(this.girisyapbtn);
            this.kayitpanel.Controls.Add(this.txtgirissifre);
            this.kayitpanel.Location = new System.Drawing.Point(156, 199);
            this.kayitpanel.Name = "kayitpanel";
            this.kayitpanel.ShadowDecoration.Parent = this.kayitpanel;
            this.kayitpanel.Size = new System.Drawing.Size(407, 362);
            this.kayitpanel.TabIndex = 14;
            this.kayitpanel.Visible = false;
            // 
            // adsoyadbox
            // 
            this.adsoyadbox.Animated = true;
            this.adsoyadbox.AutoRoundedCorners = true;
            this.adsoyadbox.BackColor = System.Drawing.Color.Transparent;
            this.adsoyadbox.BorderColor = System.Drawing.Color.Transparent;
            this.adsoyadbox.BorderRadius = 17;
            this.adsoyadbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsoyadbox.DefaultText = "İsim Soyisim";
            this.adsoyadbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adsoyadbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adsoyadbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsoyadbox.DisabledState.Parent = this.adsoyadbox;
            this.adsoyadbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adsoyadbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsoyadbox.FocusedState.Parent = this.adsoyadbox;
            this.adsoyadbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adsoyadbox.HoverState.Parent = this.adsoyadbox;
            this.adsoyadbox.Location = new System.Drawing.Point(111, 211);
            this.adsoyadbox.Name = "adsoyadbox";
            this.adsoyadbox.PasswordChar = '\0';
            this.adsoyadbox.PlaceholderText = "";
            this.adsoyadbox.SelectedText = "";
            this.adsoyadbox.SelectionStart = 12;
            this.adsoyadbox.ShadowDecoration.Parent = this.adsoyadbox;
            this.adsoyadbox.Size = new System.Drawing.Size(200, 36);
            this.adsoyadbox.TabIndex = 15;
            this.adsoyadbox.Visible = false;
            this.adsoyadbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adsoyadbox_KeyPress);
            // 
            // geribtn
            // 
            this.geribtn.Animated = true;
            this.geribtn.AutoRoundedCorners = true;
            this.geribtn.BackColor = System.Drawing.Color.Transparent;
            this.geribtn.BorderRadius = 21;
            this.geribtn.CheckedState.Parent = this.geribtn;
            this.geribtn.CustomImages.Parent = this.geribtn;
            this.geribtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.geribtn.FillColor2 = System.Drawing.Color.Black;
            this.geribtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.geribtn.ForeColor = System.Drawing.Color.White;
            this.geribtn.HoverState.Parent = this.geribtn;
            this.geribtn.Location = new System.Drawing.Point(82, 253);
            this.geribtn.Name = "geribtn";
            this.geribtn.ShadowDecoration.Parent = this.geribtn;
            this.geribtn.Size = new System.Drawing.Size(52, 45);
            this.geribtn.TabIndex = 14;
            this.geribtn.Text = "Geri";
            this.geribtn.UseTransparentBackground = true;
            this.geribtn.Visible = false;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // txtgiris
            // 
            this.txtgiris.Animated = true;
            this.txtgiris.AutoRoundedCorners = true;
            this.txtgiris.BackColor = System.Drawing.Color.Transparent;
            this.txtgiris.BorderColor = System.Drawing.Color.Transparent;
            this.txtgiris.BorderRadius = 17;
            this.txtgiris.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiris.DefaultText = "T.C. Kimlik Numarası";
            this.txtgiris.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.DisabledState.Parent = this.txtgiris;
            this.txtgiris.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiris.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.FocusedState.Parent = this.txtgiris;
            this.txtgiris.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiris.HoverState.Parent = this.txtgiris;
            this.txtgiris.Location = new System.Drawing.Point(111, 70);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.PasswordChar = '\0';
            this.txtgiris.PlaceholderText = "";
            this.txtgiris.SelectedText = "";
            this.txtgiris.SelectionStart = 20;
            this.txtgiris.ShadowDecoration.Parent = this.txtgiris;
            this.txtgiris.Size = new System.Drawing.Size(200, 36);
            this.txtgiris.TabIndex = 9;
            this.txtgiris.Visible = false;
            this.txtgiris.TextChanged += new System.EventHandler(this.txtgiris_TextChanged);
            this.txtgiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiris_KeyPress_1);
            // 
            // kayitolbtn
            // 
            this.kayitolbtn.Animated = true;
            this.kayitolbtn.AutoRoundedCorners = true;
            this.kayitolbtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitolbtn.BorderRadius = 21;
            this.kayitolbtn.CheckedState.Parent = this.kayitolbtn;
            this.kayitolbtn.CustomImages.Parent = this.kayitolbtn;
            this.kayitolbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kayitolbtn.FillColor2 = System.Drawing.Color.Black;
            this.kayitolbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kayitolbtn.ForeColor = System.Drawing.Color.White;
            this.kayitolbtn.HoverState.Parent = this.kayitolbtn;
            this.kayitolbtn.Location = new System.Drawing.Point(140, 211);
            this.kayitolbtn.Name = "kayitolbtn";
            this.kayitolbtn.ShadowDecoration.Parent = this.kayitolbtn;
            this.kayitolbtn.Size = new System.Drawing.Size(125, 45);
            this.kayitolbtn.TabIndex = 13;
            this.kayitolbtn.Text = "Kayıt Ol";
            this.kayitolbtn.UseTransparentBackground = true;
            this.kayitolbtn.Visible = false;
            this.kayitolbtn.Click += new System.EventHandler(this.kayitolbtn_Click_1);
            // 
            // mailbox
            // 
            this.mailbox.Animated = true;
            this.mailbox.AutoRoundedCorners = true;
            this.mailbox.BackColor = System.Drawing.Color.Transparent;
            this.mailbox.BorderColor = System.Drawing.Color.Transparent;
            this.mailbox.BorderRadius = 17;
            this.mailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailbox.DefaultText = "Mail Adresi";
            this.mailbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.DisabledState.Parent = this.mailbox;
            this.mailbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.FocusedState.Parent = this.mailbox;
            this.mailbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.HoverState.Parent = this.mailbox;
            this.mailbox.Location = new System.Drawing.Point(111, 166);
            this.mailbox.Name = "mailbox";
            this.mailbox.PasswordChar = '\0';
            this.mailbox.PlaceholderText = "";
            this.mailbox.SelectedText = "";
            this.mailbox.SelectionStart = 11;
            this.mailbox.ShadowDecoration.Parent = this.mailbox;
            this.mailbox.Size = new System.Drawing.Size(200, 36);
            this.mailbox.TabIndex = 12;
            this.mailbox.Visible = false;
            this.mailbox.TextChanged += new System.EventHandler(this.mailbox_TextChanged);
            this.mailbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailbox_KeyPress_1);
            // 
            // girisyapbtn
            // 
            this.girisyapbtn.Animated = true;
            this.girisyapbtn.AutoRoundedCorners = true;
            this.girisyapbtn.BackColor = System.Drawing.Color.Transparent;
            this.girisyapbtn.BorderRadius = 21;
            this.girisyapbtn.CheckedState.Parent = this.girisyapbtn;
            this.girisyapbtn.CustomImages.Parent = this.girisyapbtn;
            this.girisyapbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.girisyapbtn.FillColor2 = System.Drawing.Color.Black;
            this.girisyapbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girisyapbtn.ForeColor = System.Drawing.Color.White;
            this.girisyapbtn.HoverState.Parent = this.girisyapbtn;
            this.girisyapbtn.Location = new System.Drawing.Point(140, 160);
            this.girisyapbtn.Name = "girisyapbtn";
            this.girisyapbtn.ShadowDecoration.Parent = this.girisyapbtn;
            this.girisyapbtn.Size = new System.Drawing.Size(125, 45);
            this.girisyapbtn.TabIndex = 11;
            this.girisyapbtn.Text = "Giriş Yap";
            this.girisyapbtn.UseTransparentBackground = true;
            this.girisyapbtn.Visible = false;
            this.girisyapbtn.Click += new System.EventHandler(this.girisyapbtn_Click_1);
            // 
            // txtgirissifre
            // 
            this.txtgirissifre.Animated = true;
            this.txtgirissifre.AutoRoundedCorners = true;
            this.txtgirissifre.BackColor = System.Drawing.Color.Transparent;
            this.txtgirissifre.BorderColor = System.Drawing.Color.Transparent;
            this.txtgirissifre.BorderRadius = 17;
            this.txtgirissifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgirissifre.DefaultText = "Şifre";
            this.txtgirissifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgirissifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgirissifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.DisabledState.Parent = this.txtgirissifre;
            this.txtgirissifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgirissifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.FocusedState.Parent = this.txtgirissifre;
            this.txtgirissifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgirissifre.HoverState.Parent = this.txtgirissifre;
            this.txtgirissifre.Location = new System.Drawing.Point(111, 118);
            this.txtgirissifre.Name = "txtgirissifre";
            this.txtgirissifre.PasswordChar = '\0';
            this.txtgirissifre.PlaceholderText = "";
            this.txtgirissifre.SelectedText = "";
            this.txtgirissifre.SelectionStart = 5;
            this.txtgirissifre.ShadowDecoration.Parent = this.txtgirissifre;
            this.txtgirissifre.Size = new System.Drawing.Size(200, 36);
            this.txtgirissifre.TabIndex = 10;
            this.txtgirissifre.Visible = false;
            this.txtgirissifre.TextChanged += new System.EventHandler(this.txtgirissifre_TextChanged);
            this.txtgirissifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgirissifre_KeyPress_1);
            // 
            // destekbtn
            // 
            this.destekbtn.Animated = true;
            this.destekbtn.AutoRoundedCorners = true;
            this.destekbtn.BackColor = System.Drawing.Color.Transparent;
            this.destekbtn.BorderRadius = 21;
            this.destekbtn.CheckedState.Parent = this.destekbtn;
            this.destekbtn.CustomImages.Parent = this.destekbtn;
            this.destekbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.destekbtn.FillColor2 = System.Drawing.Color.Black;
            this.destekbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destekbtn.ForeColor = System.Drawing.Color.White;
            this.destekbtn.HoverState.Parent = this.destekbtn;
            this.destekbtn.Location = new System.Drawing.Point(1069, 635);
            this.destekbtn.Name = "destekbtn";
            this.destekbtn.ShadowDecoration.Parent = this.destekbtn;
            this.destekbtn.Size = new System.Drawing.Size(125, 45);
            this.destekbtn.TabIndex = 2;
            this.destekbtn.Text = "Destek";
            this.destekbtn.UseTransparentBackground = true;
            // 
            // girisbtn
            // 
            this.girisbtn.Animated = true;
            this.girisbtn.AutoRoundedCorners = true;
            this.girisbtn.BackColor = System.Drawing.Color.Transparent;
            this.girisbtn.BorderRadius = 21;
            this.girisbtn.CheckedState.Parent = this.girisbtn;
            this.girisbtn.CustomImages.Parent = this.girisbtn;
            this.girisbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.girisbtn.FillColor2 = System.Drawing.Color.Black;
            this.girisbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girisbtn.ForeColor = System.Drawing.Color.White;
            this.girisbtn.HoverState.Parent = this.girisbtn;
            this.girisbtn.Location = new System.Drawing.Point(213, 114);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.ShadowDecoration.Parent = this.girisbtn;
            this.girisbtn.Size = new System.Drawing.Size(125, 45);
            this.girisbtn.TabIndex = 1;
            this.girisbtn.Text = "Kullanıcı Girişi";
            this.girisbtn.UseTransparentBackground = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // AnaSayfaUstPanel
            // 
            this.AnaSayfaUstPanel.BackColor = System.Drawing.Color.Transparent;
            this.AnaSayfaUstPanel.Controls.Add(this.guna2ControlBox2);
            this.AnaSayfaUstPanel.Controls.Add(this.guna2ControlBox1);
            this.AnaSayfaUstPanel.Location = new System.Drawing.Point(30, 22);
            this.AnaSayfaUstPanel.Name = "AnaSayfaUstPanel";
            this.AnaSayfaUstPanel.ShadowDecoration.Parent = this.AnaSayfaUstPanel;
            this.AnaSayfaUstPanel.Size = new System.Drawing.Size(1210, 86);
            this.AnaSayfaUstPanel.TabIndex = 0;
            this.AnaSayfaUstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaSayfaUstPanel_MouseDown);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1102, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1153, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 662);
            this.Controls.Add(this.AnaSayfaPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.AnaSayfaPanel.ResumeLayout(false);
            this.kayitpanel.ResumeLayout(false);
            this.AnaSayfaUstPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel AnaSayfaPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel AnaSayfaUstPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton destekbtn;
        private Guna.UI2.WinForms.Guna2GradientButton girisbtn;
        private Guna.UI2.WinForms.Guna2GradientButton kayitolbtn;
        private Guna.UI2.WinForms.Guna2TextBox mailbox;
        private Guna.UI2.WinForms.Guna2GradientButton girisyapbtn;
        private Guna.UI2.WinForms.Guna2TextBox txtgirissifre;
        private Guna.UI2.WinForms.Guna2TextBox txtgiris;
        private Guna.UI2.WinForms.Guna2GradientPanel kayitpanel;
        private Guna.UI2.WinForms.Guna2GradientButton geribtn;
        private Guna.UI2.WinForms.Guna2TextBox adsoyadbox;
        private Guna.UI2.WinForms.Guna2GradientButton otoparklistelebtn;
        public Guna.UI2.WinForms.Guna2GradientPanel islemlerpanel;
        private Guna.UI2.WinForms.Guna2GradientButton adminbuton;
    }
}

