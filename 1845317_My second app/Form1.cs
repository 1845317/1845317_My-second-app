using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1845317_My_second_app
{
    public partial class Form1 : Form
    {
        string username = "Mohammed"; //username
        string myPassword = "1234"; //password

        bool loggedIn = false;

        int ThisAttempt = 1;
        int MaxAttempts = 3;
        private object btnLogin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {

                while (ThisAttempt <= MaxAttempts)
                {
                    if (txtusername.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - ThisAttempt) + " attempts remaining");
                        ThisAttempt++; //
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtpassword.Text != myPassword)
                        {
                            // Incorrect password
                            ThisAttempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - ThisAttempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            //Both are correct
                            ThisAttempt = 1; // reset the number of attempts
                            loggedIn = true;
                            // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          




                            btnlogin.Text = "Logout";

                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
            else
            {
                btnlogin.Text = "Login";

                loggedIn = false;

                txtusername.Clear();
                txtpassword.Clear();


            }



        } //end login Button

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }
    }
    }

