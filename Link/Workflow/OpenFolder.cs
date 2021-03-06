﻿using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Link.Workflow
{
    public class OpenFolder : GH_Component
    {
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("2E26B9B7-C502-4D0E-B1B6-EA9748E0FEDC"); }
        }

        public OpenFolder() : base("Open Folder", "Open", "Open a folder using it's path.", "Axis", "8. Workflow")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Path", "Path", "Folder path...", GH_ParamAccess.item);
            pManager.AddBooleanParameter("Run", "Run", "Boolean trigger to open folder.", GH_ParamAccess.list);
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            string path = String.Empty;
            bool open = false;

            if (!DA.GetData(0, ref path)) return;
            if (!DA.GetData(1, ref open)) return;

            if (open)
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = path;
                prc.Start();
            }
        }
    }
}