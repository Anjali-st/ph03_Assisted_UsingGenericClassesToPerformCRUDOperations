﻿namespace Phase3Section2._32.Models
{
    public class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}