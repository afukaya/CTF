// Decompiled with JetBrains decompiler
// Type: TearORDear.LoginForm
// Assembly: TearORDear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FAD666A4-4959-43F0-9D38-7FD79F826579
// Assembly location: C:\Users\afuka\Downloads\TearORDear.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TearORDear
{
  public class LoginForm : Form
  {
    private short[] Src = new short[11]
    {
      (short) 11,
      (short) 110,
      (short) 31,
      (short) 224,
      (short) 53,
      (short) 64,
      (short) 57,
      (short) 68,
      (short) 779,
      (short) 220,
      (short) 78
    };
    private int pepper = 10;
    private string oura = "p00f123#";
    private int pp;
    private int qq;
    private int rr;
    private int ss;
    private int tt;
    private int uu;
    private int vv;
    private int ww;
    private int b;
    private string o;
    private string z;
    private string zita;
    private string m;
    private int pep;
    private string aa;
    private string username;
    private IContainer components;
    private Label Label1;
    private Label label2;
    private TextBox textBox_user;
    private TextBox textBox_pass;
    private Button button_Login;
    private Label label_Result;

        public LoginForm()
        {
          this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Label1 = new Label();
            this.label2 = new Label();
            this.textBox_user = new TextBox();
            this.textBox_pass = new TextBox();
            this.button_Login = new Button();
            this.label_Result = new Label();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(32, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(60, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "User Name";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.textBox_user.Location = new Point(110, 44);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new Size(162, 20);
            this.textBox_user.TabIndex = 1;
            this.textBox_pass.Location = new Point(110, 84);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new Size(162, 20);
            this.textBox_pass.TabIndex = 2;
            this.button_Login.Location = new Point(105, 139);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new EventHandler(this.button1_Click);
            this.label_Result.AutoSize = true;
            this.label_Result.ForeColor = Color.Red;
            this.label_Result.Location = new Point(59, 173);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new Size(0, 13);
            this.label_Result.TabIndex = 5;
            this.AcceptButton = (IButtonControl)this.button_Login;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 205);
            this.Controls.Add((Control)this.label_Result);
            this.Controls.Add((Control)this.button_Login);
            this.Controls.Add((Control)this.textBox_pass);
            this.Controls.Add((Control)this.textBox_user);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.Label1);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(LoginForm);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        /* Handles Button Login Click*/
        private void button1_Click(object sender, EventArgs e) 
        {
            this.label_Result.Text = "";
            this.kapa(sender, e); 
            this.pep = 0;
            this.aa = this.Multiply(this.encrypted1(this.textBox_user.Text).Substring(0, 5), -1);
            this.aa = this.aa.Remove(this.aa.Length - 1);
            string s = this.Multiply(this.oura, -9);
            if (this.username == this.o && this.check1(s)) 
            {
                int num = (int)MessageBox.Show("Correct!");
            }
            else
                this.label_Result.Text = "WRONG CREDENTIALS! Try Again...";
        }

        private bool check1(string s)
        {
            string[] s1 = new string[26] {"q","w","e","r","t","y","u","i","o","p","a",nameof (s),"d","f","g","h","j","k","l","z","x","c","v","b",
                "n","m"};
            string s2 = s1[3] + s1[8] + s1[7] + s1[(int)Math.Sqrt(2.0)];
            return this.check(s1, s2);
        }

        private bool check2(string[] s1, string s2)
        {
            string[] s1_1 = new string[26]{"q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m"};
            string s2_1 = s1_1[3] + s1_1[8] + s1_1[7] + s1_1[(int)Math.Sqrt(2.0)];
            return this.check3(s1_1, s2_1);
        }

        private bool check3(string[] s1, string s2)
        {
            string[] s1_1 = new string[26] {"q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m"};
            string s2_1 = s1_1[3] + s1_1[8] + s1_1[7] + s1_1[(int)Math.Sqrt(2.0)];
            return this.check4(s1_1, s2_1);
        }

        private bool check4(string[] s1, string s2)
        {
            string[] s1_1 = new string[26]{"q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m"};
            string s2_1 = s1_1[3] + s1_1[8] + s1_1[7] + s1_1[(int)Math.Sqrt(2.0)];
            return this.check(s1_1, s2_1);
        }

        private bool check(string[] s1, string s2)
        {
            string[] strArray = new string[26]{"q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","q","b","n","m"};
            string str = strArray[3] + strArray[8] + strArray[7] + strArray[(int)Math.Sqrt(2.0)];
            if (this.textBox_user.Text == this.aa) return strArray[0] == strArray[22];

            return false;
        }

        /* Does nothing but init pp with 128 and call linear with this value 
           pp will be used later*/
        private unsafe void kapa(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2;
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            int num8;

            this.z = "";
            this.o = "";
            this.m = "";
            
            int* numPtr1 = &num2;
            int* numPtr2 = &num3;
            int* numPtr3 = &num4;
            int* numPtr4 = &num5;
            int* numPtr5 = &num6;
            int* numPtr6 = &num7;
            int* numPtr7 = &num8;
            int* numPtr8 = &num1;

            *numPtr1 = 79;
            *numPtr2 = 128;
            *numPtr3 = 128;
            *numPtr4 = 105;
            *numPtr5 = 112;
            *numPtr6 = 112;
            *numPtr7 = 129;
            *numPtr8 = 130;

            this.pp = num2; //pp = 128

            this.linear(this.pp); // pass 128 
        }

        /* Lots of yada yada with pp and call expo with j1 = 128*/
        private void linear(int j)
        {
            int j1 = j; //128
            int num = j; //128

            this.o = char.ToString((char)j); //Global variable o = "Ç"
            j = this.pp + 75 + 105 + 108 + 108 + 36; // pp = 128; j = 455
            this.pp = j + num; // pp = 455 + 128 = 583
            this.qq = (this.pp -= j); //qq = pp - j; pp = pp - j = 455
            this.expo(j1); // j1 = 128
        }

        private void expo(int j)
        {
            short[] numArray = new short[12]
            {
                (short) 104,
                (short) 108,
                (short) 100,
                (short) 101,
                (short) 163,
                (short) 100,
                (short) 122,
                (short) 111,
                (short) 112,
                (short) 122,
                (short) 101,
                (short) 270
            };
            int num = j;                             //128
            this.b = num - 74;                       //b = 128 - 74 = 54
            this.pp += j + num;                      //pp = pp + j + num -> pp = 455 + 128 + 128 = 711
            this.o = char.ToString((char)j);         //o = "Ç"
            j = this.pp + 75 + 105 + 108 + 108 + 36; //j = 1038
            this.pp += j + num;                      //pp = pp + j + num -> pp = 711+1038+128 = 1877

            this.pp += j + num + this.via(1, this.qq);

            this.qq = this.pp - j + (int)numArray[this.b - 1 + 10 - 9 + 2 - 1 - 1];
            this.pp -= j;
            this.qq = (int)numArray[this.b - 1 + 10 - 9 + 2 - 1 - 1];
            this.o += char.ToString((char)this.qq);

            this.via(2, this.qq);
            this.via(-2, this.qq);
            this.via(-1, this.qq);
            this.via(0, this.qq);
        }

        /* Decripts the password? */
        private int via(int type, int j)
        {
            short[] numArray = new short[10]
            {
                (short) 115,
                (short) 112,
                (short) 115,
                (short) 114,
                (short) 115,
                (short) 116,
                (short) 117,
                (short) 118,
                (short) 119,
                (short) 110
            };
            int num1 = j + (int)numArray[1] * (int)numArray[5] ^ 272;
            int num2;
            if (type == 0)
            {
                char.ToString((char)(j + 11));
                char c = (char)((int)numArray[2] - 101 + (int)numArray[9] - 9);
                this.o += char.ToString(c);
                this.o += char.ToString(c);
                num2 = num1 + (Encoding.ASCII.GetBytes(this.o).Length + j + (int)numArray[1] * (int)numArray[5] ^ 272);
            }
            else if (type > 1)
            {
                char.ToString((char)(j + 11));
                this.o += char.ToString((char)((uint)this.Src[2] + 12U + (uint)this.Src[10]));
                num2 = num1 + (Encoding.ASCII.GetBytes(this.o).Length + j + (int)numArray[1] * (int)numArray[5] ^ 272);
            }
            else
                num2 = num1 - (Encoding.ASCII.GetBytes(this.o).Length + j + (int)numArray[1] * (int)numArray[5] ^ 272);
            return num2;
        }

        

        

      

    

    private string encrypted1(string s1)
    {
      string[] strArray = new string[26]
      {
        "1",
        "2",
        "4",
        "g",
        "h",
        "l",
        "o",
        "3",
        "g",
        "p",
        "p",
        "k",
        "d",
        "f",
        "s",
        "e",
        "w",
        "r",
        "t",
        "z",
        "u",
        "i",
        "i",
        "&",
        "$",
        "_"
      };
      if (this.pep == 0)
        s1 = strArray[0] + strArray[4] + strArray[10] + strArray[22] + strArray[9];
      if (++this.pep == this.pepper)
      {
        this.o = this.encrypted10(this.textBox_pass.Text);
        return s1;
      }
      string str = strArray[3] + strArray[8] + strArray[8] + strArray[(int) Math.Sqrt(18.0)];
      s1 += this.encrypted1(this.textBox_pass.Text);
      if (s1 == str)
        return str;
      return s1;
    }

    private string encrypted10(string s1)
    {
      string[] strArray = new string[26]
      {
        "a",
        "b",
        "c",
        "d",
        "e",
        "f",
        "g",
        "h",
        "i",
        "j",
        "k",
        "l",
        "m",
        "n",
        "o",
        "p",
        "q",
        "r",
        "s",
        "t",
        "u",
        "v",
        "w",
        "x",
        "y",
        "z"
      };
      string str1 = strArray[3] + strArray[8] + strArray[17] + strArray[(int) Math.Sqrt(18.0)];
      string str2 = this.encrypted11(this.textBox_pass.Text);
      if (s1 == str1)
        return str1;
      return str2;
    }

    public string Multiply(string s, int n)
    {
      char[] charArray = s.ToCharArray();
      Array.Reverse((Array) charArray);
      this.username = this.textBox_pass.Text;
      return new string(charArray);
    }

    private string encrypted2(string s1)
    {
      string[] strArray = new string[26]
      {
        "a",
        "b",
        "c",
        "d",
        "e",
        "f",
        "g",
        "h",
        "i",
        "j",
        "k",
        "l",
        "m",
        "n",
        "o",
        "p",
        "q",
        "r",
        "s",
        "t",
        "u",
        "v",
        "w",
        "x",
        "y",
        "z"
      };
      string str1 = strArray[3] + strArray[8] + strArray[17] + strArray[(int) Math.Sqrt(18.0)];
      string str2 = this.encrypted10(s1);
      if (s1 == str1)
        return str1;
      return str2;
    }

    private string encrypted11(string s1)
    {
      string[] strArray = new string[26]
      {
        "q",
        "w",
        "e",
        "r",
        "t",
        "y",
        "u",
        "i",
        "o",
        "p",
        "a",
        "s",
        "d",
        "f",
        "g",
        "h",
        "j",
        "k",
        "l",
        "z",
        "x",
        "c",
        "v",
        "b",
        "n",
        "m"
      };
      string str = strArray[3] + strArray[8] + strArray[7] + strArray[(int) Math.Sqrt(2.0)];
      if (s1 == str)
        return str;
      return str + "!@#";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }
  }
}
