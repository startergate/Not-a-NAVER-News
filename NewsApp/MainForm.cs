﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewsApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private void MainForm_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=news;uid=news;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet();
      
      try
      {
        conn.Open();
        if (conn.State != ConnectionState.Open)
        {
          MessageBox.Show("What happened to the internet?");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
      comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // TODO: DB 연결해서 회원가입 / 로그인
      switch (comboBox1.SelectedIndex)
      {
        case 0:
          // TODO: Login Process
          
          break;
        case 1:
          // TODO: Register Process
          break;
        default:
          MessageBox.Show("TF you doing here nigga, identify yourself, who tf are you");
          break;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0:
          label2.Text = "아이디";
          button1.Text = "로그인";
          break;
        case 1:
          label2.Text = "이름";
          button1.Text = "회원가입";
          break;
        default:
          MessageBox.Show("STOP RIGHT THERE, CRIMINAL SCUM!");
          break;
      }
    }
  }
}