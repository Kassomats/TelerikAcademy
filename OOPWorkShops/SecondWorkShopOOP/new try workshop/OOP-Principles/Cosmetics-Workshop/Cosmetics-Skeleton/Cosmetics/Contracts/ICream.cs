﻿namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    public interface ICream : IProduct
    {


        ScentType Scent { get; }
    }
}