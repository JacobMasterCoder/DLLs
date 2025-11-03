CZK.Xeno.Inject();
            if (CZK.Xeno.IsInjected())
            {
                MessageBox.Show("Injected via API!");
                checkInjection()
            }
            else
            {
                MessageBox.Show("Failed to inject via API.");
            }

if (CZK.Xeno.IsInjected())
            {
                string script = fastColoredTextBox1.Text;
                CZK.Xeno.Execute(script);
            }
            else
            {
                MessageBox.Show("Not injected. Please attach first.");
            }
