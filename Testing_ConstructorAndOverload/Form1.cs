using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_ConstructorAndOverload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var goblin = new Card(name: "哥布林", attack: 3, health: 2);
            var warrior = new Card(name: "戰士", attack: 4, health: 3);
            warrior.Hit(goblin);
        }
    }

    public class Card
    {
        private string _name;
        private int _attack;
        private int _health;
        public Card(string name, int attack, int health)
        {
            _name = name;
            _attack = attack;
            _health = health;
        }

        // 會呼叫上面那個建構式
        public Card(string name) : this(name: name, attack: 5, health: 5)
        {
            // 呼叫完 Card(name, attack, health) 之後做的事
        }

        // 會呼叫上面那一個建構式
        public Card() : this(name: "Noname")
        {
            // 呼叫完 Card(name) 之後做的事   
        }
    }

}
