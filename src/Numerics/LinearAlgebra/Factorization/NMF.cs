using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NMF<T> : IFactorizer<T>
        where T : struct, IEquatable<T>, IFormattable
    {
        public void Factor(Matrix<T> vInput, int rank, Matrix<T> wResult, Matrix<T> hResult)
        {
            throw new NotImplementedException();
        }
        //TODO: Cost functions:
        ///http://hebb.mit.edu/people/seung/papers/nmfconverge.pdf
        //1. Euclidean Distance
        //2. Divergence
    }
}
