using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EB
{
    class funciones
    {

      

        
        public void showAllControls(Control _this)
        {
            foreach (Control c in _this.Controls)
            {
                c.Visible = true;
                if (c.GetType() == typeof(Panel) || c.GetType() == typeof(GroupBox)) showAllControls(c);
            }
        }
       
        public bool isInArray(string a, string[] b)
        {
            for (int x = 0; x < b.Length; x++)
            {
                if (b[x].ToLower() == a.ToLower()) return true;
            }
            return false;
        }
        public int getArrayLength(string[] t)
        {
            int a = 0;
            for (int x = 0; x < t.Length; x++)
            {
                if (t[x] != null) a++;
            }
            return a;
        }
        public int getArrayLength(Control[] t)
        {
            int a = 0;
            for (int x = 0; x < t.Length; x++)
            {
                if (t[x] != null) a++;
            }
            return a;
        }
        public int getArrayLength(double[] t)
        {
            int a = 0;
            for (int x = 0; x < t.Length; x++)
            {
                if (t[x] != null) a++;
            }
            return a;
        }
        public int getNumberOfControls(Control c)
        {
            int n = 0;
            foreach (Control x in c.Controls)
            {
                if (x.GetType() == typeof(Panel) || x.GetType() == typeof(GroupBox)) n += getNumberOfControls(x);
                else n++;
            }
            return n;
        }
        public int getNumberOfVisibleControls(Control c)
        {
            int n = 0;
            foreach (Control x in c.Controls)
            {
                if (x.Visible == true)
                {
                    if (x.GetType() == typeof(Panel) || x.GetType() == typeof(GroupBox)) n += getNumberOfVisibleControls(x);
                    else n++;
                }
            }
            return n;
        }
        public Control[] getControls(Control c)
        {
            Control[] ret = new Control[getNumberOfControls(c)];
            int n = 0;
            foreach (Control k in c.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    Control[] tmp = getControls(k);
                    foreach (Control t in tmp)
                    {
                        ret[n++] = t;
                    }
                }
                else ret[n++] = k;
            }
            return ret;
        }
        public Control[] getVisibleControls(Control c)
        {

            Control[] ret = new Control[getNumberOfVisibleControls(c)];
            int n = 0;
            foreach (Control k in c.Controls)
            {
                if (k.Visible == true)
                {
                    if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                    {
                        Control[] tmp = getVisibleControls(k);
                        foreach (Control t in tmp)
                        {
                            ret[n++] = t;
                        }
                    }
                    else ret[n++] = k;
                }
            }
            return ret;
        }
        public int getNumberOfControlsOfType(Control c, string type)
        {
            int n = 0;
            foreach (Control k in c.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox)) n += getNumberOfControlsOfType(k, type);
                else
                {

                    if (k.GetType().ToString() == type) n++;
                }
            }
            return n;
        }
        public string[,] getControlsNameAndText(Control c)
        {
            string[,] ret = new string[getNumberOfControls(c), 2];
            int n = 0;
            foreach (Control k in getControls(c))
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    string[,] aux = new string[getNumberOfControls(k), 2];
                    for (int x = 0; x < aux.GetLength(0); x++)
                    {
                        ret[x, 0] = aux[x, 0];
                        ret[x, 1] = aux[x, 1];
                        n++;
                    }
                }
                else
                {
                    ret[n, 0] = k.Name;
                    ret[n++, 1] = k.Text;
                }
            }
            return ret;
        }
        public void setControlsTextToDefault(Control c, string[,] def)
        {
            int n = 0;
            foreach (Control k in getControls(c))
            {
                k.Name = def[n, 0];
                k.Text = def[n++, 1];
            }
        }
        public Control[] getAllControlsOfType(Control c, string type)
        {

            type = type.Split('.').Length > 3 ? type : "System.Windows.Forms." + type;
            Control[] ret = new Control[getNumberOfControlsOfType(c, type)];
            int n = 0;
            foreach (Control k in c.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    Control[] aux = new Control[getNumberOfControlsOfType(k, type)];
                    aux = getAllControlsOfType(k, type);
                    foreach (Control t in aux)
                    {
                        ret[n++] = t;
                    }
                }
                else if (k.GetType().ToString() == type) ret[n++] = k;
            }
            return ret;
        }
        public string[] getControlsNames(Control[] c)
        {
            string[] ret = new String[getArrayLength(c)];
            int n = 0;
            foreach (Control t in c)
            {
                ret[n++] = t.Name;
            }
            return ret;
        }
        public Control[] getDefaultControls(Control form, Control[] def)
        {
            Control[] formControls = new Control[getNumberOfControls(form)];
            int n = 0;
            foreach (Control k in form.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    getDefaultControls(k, def);
                }
                else if (isInArray(k.Name, getControlsNames(def))) formControls[n++] = getControlByName(k.Name, def);
            }
            return formControls;
        }
        public Control getControlByName(string name, Control[] c)
        {
            Control ret = null;
            foreach (Control k in c)
            {
                if (name == k.Name) return k;
            }
            return ret;
        }
        public Control[] controlsByName(Control form, string[] names)
        {
            Control[] ret = new Control[names.Length];
            int n = 0;
            foreach (Control k in form.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    Control[] tmp = controlsByName(k, names);
                    foreach (Control x in tmp)
                    {
                        if (getArrayLength(tmp) > 0) ret[n++] = x;
                    }
                }
                else if (isInArray(k.Name, names)) ret[n++] = k;
                else if (getArrayLength(ret) == getArrayLength(names)) break;
            }
            return ret;
        }
        public void clearAllTextBoxes(Control _this)
        {
            foreach (Control k in getAllControlsOfType(_this, "TextBox"))
            {
                k.Text = "";
            }
        }
        public void setControlsToDefault(Control _this, Control[] def, DataGridView dgv)
        {
            while (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    try
                    {
                        dgv.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            }
            clearAllTextBoxes(_this);
            foreach (Control k in _this.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    if (isInArray(k.Name, getControlsNames(def)))
                    {
                        foreach (Control t in k.Controls)
                        {
                            if (!isInArray(t.Name, getControlsNames(def))) t.Visible = false;
                        }
                    }
                    else k.Visible = false;
                }
                else if (!isInArray(k.Name, getControlsNames(def))) k.Visible = false;
            }
        }

        public void setControlsToDefault(Control _this, Control[] def)
        {
            clearAllTextBoxes(_this);
            foreach (Control k in _this.Controls)
            {
                if (k.GetType() == typeof(Panel) || k.GetType() == typeof(GroupBox))
                {
                    if (isInArray(k.Name, getControlsNames(def)))
                    {
                        foreach (Control t in k.Controls)
                        {
                            if (!isInArray(t.Name, getControlsNames(def)))
                            {
                                t.Visible = false;
                            }
                            t.Text = getControlByName(t.Name, def).Text;
                        }
                    }
                    else k.Visible = false;
                }
                else
                {
                    if (!isInArray(k.Name, getControlsNames(def)))
                    {
                        k.Visible = false;

                    }
                    k.Text = getControlByName(k.Name, def).Text;
                }
            }
        }
        public bool controlsNotEmpty(Control[] c)
        {
            if (getArrayLength(c) == 0) return false;
            foreach (Control f in c)
            {
                if (f.Text.Length == 0) return false;
            }
            return true;
        }

        public bool hasDecimals(double x)
        {
            return x.ToString().Split('.').Length > 1 ? true : false;
        }
        public double removeNumbersAfterNDot(double x, int n)
        {
            n++;
            double ret = 0;
            string t = x.ToString();
            string strret = "";
            bool dotFound = false;
            int aftDotFound = 0;
            for (int a = 0; a < t.Length; a++)
            {
                if (t[a] == '.') dotFound = true;
                if (dotFound && aftDotFound < n)
                {
                    strret += t[a];
                    aftDotFound++;
                }
                else if (aftDotFound >= n) break;
                else strret += t[a];
            }
            ret = Convert.ToDouble(strret);
            return ret;
        }

        public void resizeControlToVisibleChildren(Control _this, int marginW, int marginH)
        {
            int width = 0;
            int height = 0;
            foreach (Control c in _this.Controls)
            {
                if (c.Visible)
                {
                    if (c.Left + c.Width > width) width = c.Left + c.Width;
                    if (c.Top + c.Height > height) height = c.Top + c.Height;
                }
            }
            _this.Height = height + marginH;
            _this.Width = width + marginW;
        }
    }
}