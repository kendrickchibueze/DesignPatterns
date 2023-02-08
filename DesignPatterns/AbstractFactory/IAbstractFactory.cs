using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {

        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public interface IAbstractProductB
    {

     
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }

    public interface IAbstractProductA
    {

        string UsefulFunctionA();
    }
}
