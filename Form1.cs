// Decompiled by: damy.pw | 2017.09.09

//▒█▀▀▄ █▀▀█ █▀▄▀█ █░░█ 
//▒█░▒█ █▄▄█ █░▀░█ █▄▄█ 
//▒█▄▄▀ ▀░░▀ ▀░░░▀ ▄▄▄█ 


using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace See_MTA_Rendőrség__jelentés_
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox10;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private TextBox textBox3;
    private TextBox textBox11;
    private Button button11;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string str10 = "";
      str1 = this.textBox1.Text;
      str2 = this.textBox2.Text;
      str3 = this.textBox3.Text;
      str4 = this.textBox4.Text;
      str5 = this.textBox5.Text;
      str6 = this.textBox10.Text;
      str7 = this.textBox6.Text;
      str8 = this.textBox7.Text;
      str9 = this.textBox8.Text;
      str10 = this.textBox9.Text;
      Clipboard.SetText("[center][img]http://www.kephost.com/images/2016/06/21/logomasolata.png[/img][/center]\n \n \n [size=13pt][color=#7CC576][b]Törzsneve, és rendfokozata:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox1.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Felettesek, kollégák neve, és rendfokozata:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox2.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Körzetét, alosztályát, főosztályát adja meg:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox3.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Intézkedést kezdeményezett egység megnevezése:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox4.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Intézkedés időpontja (dátum, és nap), és helyszíne:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox5.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Intézkedés típusa, és indoka:[/b][/color][/size]\n \n[color=#FACC2E]" + this.textBox10.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Szabálysértést hosszan írja le, a megnevezését:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox6.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Adja meg a bírság összegét dollár-ban, pontal tagolva:[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox7.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Képi információk: (OOC képek, RP, és ticket látszódjon)[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox8.Text + "[/color]\n \n[size=13pt][color=#7CC576][b]Az intézkedés teljes leírása: (3-4db hosszú mondat)[/b][/color][/size]\n \n[color=#FFFFFF]" + this.textBox9.Text + "[/color]");
      int num = (int) MessageBox.Show("1. 2. lépés kész, az adatok a vágólapra másolva!");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.textBox1.Text = "";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.textBox2.Text = "";
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.textBox4.Text = "";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.textBox5.Text = "";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.textBox10.Text = "";
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.textBox6.Text = "";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.textBox7.Text = "";
    }

    private void button9_Click(object sender, EventArgs e)
    {
      this.textBox8.Text = "";
    }

    private void button10_Click(object sender, EventArgs e)
    {
      this.textBox9.Text = "";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.textBox3.Text = "";
    }

    private void button11_Click(object sender, EventArgs e)
    {
      Process.Start("http://kephost.com/");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.pictureBox1 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox8 = new TextBox();
      this.textBox9 = new TextBox();
      this.textBox10 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.button9 = new Button();
      this.button10 = new Button();
      this.textBox3 = new TextBox();
      this.textBox11 = new TextBox();
      this.button11 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(242, 5);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(487, 152);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
      this.pictureBox3.Location = new Point(479, 163);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(513, 364);
      this.pictureBox3.TabIndex = 2;
      this.pictureBox3.TabStop = false;
      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(-3, 163);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(476, 362);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      this.textBox1.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox1.BorderStyle = BorderStyle.FixedSingle;
      this.textBox1.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox1.ForeColor = Color.White;
      this.textBox1.Location = new Point(149, 203);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(173, 23);
      this.textBox1.TabIndex = 3;
      this.textBox2.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox2.BorderStyle = BorderStyle.FixedSingle;
      this.textBox2.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox2.ForeColor = Color.White;
      this.textBox2.Location = new Point(149, 277);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(173, 23);
      this.textBox2.TabIndex = 4;
      this.textBox4.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox4.BorderStyle = BorderStyle.FixedSingle;
      this.textBox4.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox4.ForeColor = Color.White;
      this.textBox4.Location = new Point(149, 425);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(173, 23);
      this.textBox4.TabIndex = 6;
      this.textBox5.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox5.BorderStyle = BorderStyle.FixedSingle;
      this.textBox5.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox5.ForeColor = Color.White;
      this.textBox5.Location = new Point(149, 504);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(173, 23);
      this.textBox5.TabIndex = 7;
      this.textBox6.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox6.BorderStyle = BorderStyle.FixedSingle;
      this.textBox6.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox6.ForeColor = Color.White;
      this.textBox6.Location = new Point(637, 277);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(173, 23);
      this.textBox6.TabIndex = 8;
      this.textBox7.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox7.BorderStyle = BorderStyle.FixedSingle;
      this.textBox7.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox7.ForeColor = Color.White;
      this.textBox7.Location = new Point(637, 351);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(173, 23);
      this.textBox7.TabIndex = 9;
      this.textBox8.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox8.BorderStyle = BorderStyle.FixedSingle;
      this.textBox8.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox8.ForeColor = Color.White;
      this.textBox8.Location = new Point(637, 425);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(173, 23);
      this.textBox8.TabIndex = 10;
      this.textBox9.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox9.BorderStyle = BorderStyle.FixedSingle;
      this.textBox9.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox9.ForeColor = Color.White;
      this.textBox9.Location = new Point(527, 497);
      this.textBox9.Multiline = true;
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(382, 60);
      this.textBox9.TabIndex = 11;
      this.textBox10.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox10.BorderStyle = BorderStyle.FixedSingle;
      this.textBox10.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox10.ForeColor = Color.White;
      this.textBox10.Location = new Point(637, 203);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new Size(173, 23);
      this.textBox10.TabIndex = 12;
      this.button1.BackColor = Color.FromArgb(17, 17, 17);
      this.button1.Cursor = Cursors.Default;
      this.button1.FlatStyle = FlatStyle.Popup;
      this.button1.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button1.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button1.Location = new Point(328, 203);
      this.button1.Name = "button1";
      this.button1.Size = new Size(26, 27);
      this.button1.TabIndex = 13;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.BackColor = Color.FromArgb(17, 17, 17);
      this.button2.Cursor = Cursors.Default;
      this.button2.FlatStyle = FlatStyle.Popup;
      this.button2.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button2.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button2.Location = new Point(328, 277);
      this.button2.Name = "button2";
      this.button2.Size = new Size(26, 27);
      this.button2.TabIndex = 14;
      this.button2.Text = "X";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.BackColor = Color.FromArgb(17, 17, 17);
      this.button3.Cursor = Cursors.Default;
      this.button3.FlatStyle = FlatStyle.Popup;
      this.button3.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button3.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button3.Location = new Point(328, 351);
      this.button3.Name = "button3";
      this.button3.Size = new Size(26, 27);
      this.button3.TabIndex = 15;
      this.button3.Text = "X";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.BackColor = Color.FromArgb(17, 17, 17);
      this.button4.Cursor = Cursors.Default;
      this.button4.FlatStyle = FlatStyle.Popup;
      this.button4.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button4.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button4.Location = new Point(328, 425);
      this.button4.Name = "button4";
      this.button4.Size = new Size(26, 27);
      this.button4.TabIndex = 16;
      this.button4.Text = "X";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.BackColor = Color.FromArgb(17, 17, 17);
      this.button5.Cursor = Cursors.Default;
      this.button5.FlatStyle = FlatStyle.Popup;
      this.button5.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button5.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button5.Location = new Point(328, 504);
      this.button5.Name = "button5";
      this.button5.Size = new Size(26, 27);
      this.button5.TabIndex = 17;
      this.button5.Text = "X";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.FromArgb(17, 17, 17);
      this.button6.Cursor = Cursors.Default;
      this.button6.FlatStyle = FlatStyle.Popup;
      this.button6.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button6.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button6.Location = new Point(816, 203);
      this.button6.Name = "button6";
      this.button6.Size = new Size(26, 27);
      this.button6.TabIndex = 18;
      this.button6.Text = "X";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.BackColor = Color.FromArgb(17, 17, 17);
      this.button7.Cursor = Cursors.Default;
      this.button7.FlatStyle = FlatStyle.Popup;
      this.button7.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button7.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button7.Location = new Point(816, 277);
      this.button7.Name = "button7";
      this.button7.Size = new Size(26, 27);
      this.button7.TabIndex = 19;
      this.button7.Text = "X";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.BackColor = Color.FromArgb(17, 17, 17);
      this.button8.Cursor = Cursors.Default;
      this.button8.FlatStyle = FlatStyle.Popup;
      this.button8.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button8.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button8.Location = new Point(816, 351);
      this.button8.Name = "button8";
      this.button8.Size = new Size(26, 27);
      this.button8.TabIndex = 20;
      this.button8.Text = "X";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button9.BackColor = Color.FromArgb(17, 17, 17);
      this.button9.Cursor = Cursors.Default;
      this.button9.FlatStyle = FlatStyle.Popup;
      this.button9.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button9.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button9.Location = new Point(816, 425);
      this.button9.Name = "button9";
      this.button9.Size = new Size(26, 27);
      this.button9.TabIndex = 21;
      this.button9.Text = "X";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button10.BackColor = Color.FromArgb(17, 17, 17);
      this.button10.Cursor = Cursors.Default;
      this.button10.FlatStyle = FlatStyle.Popup;
      this.button10.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button10.ForeColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.button10.Location = new Point(918, 497);
      this.button10.Name = "button10";
      this.button10.Size = new Size(26, 27);
      this.button10.TabIndex = 22;
      this.button10.Text = "X";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.textBox3.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox3.BorderStyle = BorderStyle.FixedSingle;
      this.textBox3.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox3.ForeColor = Color.White;
      this.textBox3.Location = new Point(149, 355);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(173, 23);
      this.textBox3.TabIndex = 23;
      this.textBox11.BackColor = Color.FromArgb(17, 17, 17);
      this.textBox11.BorderStyle = BorderStyle.FixedSingle;
      this.textBox11.Enabled = false;
      this.textBox11.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.textBox11.ForeColor = Color.White;
      this.textBox11.Location = new Point(12, 12);
      this.textBox11.Multiline = true;
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new Size(382, 93);
      this.textBox11.TabIndex = 24;
      this.textBox11.Text = "A program használata: \r\n1. Beírod a cellákba a megfelelő adatokat.\r\n2. Rákattintassz 2x a rendőrség jelre.\r\n3. Bemásolod (CTRL+V) fórumra a kész jelentést.\r\nAz X gombbal bírod kitörölni az adatot.\r\n ";
      this.button11.BackColor = Color.Black;
      this.button11.Cursor = Cursors.Default;
      this.button11.FlatStyle = FlatStyle.Popup;
      this.button11.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.button11.ForeColor = Color.White;
      this.button11.Location = new Point(848, 425);
      this.button11.Name = "button11";
      this.button11.Size = new Size(77, 29);
      this.button11.TabIndex = 25;
      this.button11.Text = "Kephost";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.ClientSize = new Size(956, 576);
      this.Controls.Add((Control) this.button11);
      this.Controls.Add((Control) this.textBox11);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox10);
      this.Controls.Add((Control) this.textBox9);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.textBox7);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "See MTA V3 jelentés író";
      this.Load += new EventHandler(this.Form1_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
