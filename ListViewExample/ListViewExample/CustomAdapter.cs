using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewExample
{
    public class CustomAdapter : BaseAdapter<string>
    {
        string[] items;
        Activity context;

        public CustomAdapter(Activity context, string[] items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override string this[int position]
        {
            get {return items[position]; }
        }
        //public override string this[int position] => throw new NotImplementedException();

        public override int Count => throw new NotImplementedException();

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
    }
}