using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_ObjectAndClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var goblin = new Card();
            var warrior = new Card();
            warrior.Hit(goblin);
        }
    }



    //建立類別
    public class Card
    {
        public string Name;
        public int Level;
        public int Attack;
        public int Health;
        public string Description;

        // 攻擊目標卡片
        public void Hit(Card target)
        {
            target.damage(this.Attack);
        }

        // 被攻擊的時候扣血
        public void damage(int attack)
        {
            this.Health -= attack;
            if (this.Health <= 0)
            {
                MessageBox.Show("Died");
            }
        }
    }

}
