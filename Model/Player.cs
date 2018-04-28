﻿using SaveTheCommunism.Utilities;
using System;

namespace SaveTheCommunism.Model
{
    public class Player : Character
    {
        public Player(int health, int damage, Vector position, Vector speed, Vector velocity) 
            : base(health, damage, position, speed, velocity)
        {
            //тут придумаем значения по умолчанию, пусть пока будут рандомные
            IsAlive = true;
            Health = 10;
            Damage = 2;
            Position = new Vector(10, 10);
            Speed = new Vector(1, 2);
            Velocity = new Vector(1, 1);
        }

        //переименовать, слишком общее название
        //public int Ability { get; set; }

        //public override void Hit(Character another)
        //{
        //    base.Hit(another);
        //    Ability += 1;
        //}

        //public void Recruit(Enemy enemy)
        //{

        //}

        //это дичь, потом убрать
        //private void SetState(Vector position, bool isHit)
        //{
        //    StateChanged?.Invoke(position, isHit);
        //}

        //public event Action<Vector, bool> StateChanged;
    }
}