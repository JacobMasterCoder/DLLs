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


private void checkInjection()
        {
            if (CZK.Xeno.IsInjected())
            {
                textBox1.Text = "Injected"; // Replace with your textbox's name
            }
            else
            {
                textBox1.Text = "Not Injected"; // Replace with your textbox's name
            }
        }
