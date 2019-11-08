using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base("Invalid input: " + message)
    {
    }
}