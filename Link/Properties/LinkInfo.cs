﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Link
{
    public class LinkInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Link";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "A data transfer and communication library for Grasshopper.";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("11c185f9-e66e-4fbe-87db-e0686ffa123e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Axis Consulting";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "rhu@axisarch.tech";
            }
        }
    }
}
