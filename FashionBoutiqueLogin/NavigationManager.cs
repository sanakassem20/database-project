using System;
using System.Collections.Generic;
using System.Windows.Forms;

public static class NavigationManager
{
    private static Stack<Form> _formStack = new Stack<Form>();

    public static void Push(Form form)
    {
        // Push the current form onto the stack
        _formStack.Push(form);
    }

    public static Form Pop()
    {
        // Pop the top form from the stack and return it
        if (_formStack.Count > 0)
        {
            return _formStack.Pop();
        }
        return null;
    }

    public static void ShowPreviousForm()
    {
        Form previousForm = Pop();
        if (previousForm != null)
        {
            previousForm.Show();
        }
        else
        {
            MessageBox.Show("No previous form to navigate back to.");
        }
    }
}
