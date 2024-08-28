//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> CloudsConvertStorage
    /// </summary>
    public sealed class CloudsConvertStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> CloudsConvertStorage Constructor
        /// </summary>
        public CloudsConvertStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    /// <summary>
    /// >> CloudsConvertCalls
    /// </summary>
    public sealed class CloudsConvertCalls
    {
        
        /// <summary>
        /// >> clouds_to_vebnc
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CloudsToVebnc(Substrate.NetApi.Model.Types.Primitive.U128 value, Substrate.NetApi.Model.Types.Primitive.U128 expected_min_vebnc)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(expected_min_vebnc.Encode());
            return new Method(137, "CloudsConvert", 0, "clouds_to_vebnc", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> charge_vbnc
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ChargeVbnc(Substrate.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            return new Method(137, "CloudsConvert", 1, "charge_vbnc", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> CloudsConvertConstants
    /// </summary>
    public sealed class CloudsConvertConstants
    {
        
        /// <summary>
        /// >> LockedBlocks
        ///  locked blocks for veBNC converted from clouds
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LockedBlocks()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x8066A000");
            return result;
        }
    }
    
    /// <summary>
    /// >> CloudsConvertErrors
    /// </summary>
    public enum CloudsConvertErrors
    {
        
        /// <summary>
        /// >> NotEnoughBalance
        /// </summary>
        NotEnoughBalance,
        
        /// <summary>
        /// >> CalculationOverflow
        /// </summary>
        CalculationOverflow,
        
        /// <summary>
        /// >> LessThanExpected
        /// </summary>
        LessThanExpected,
        
        /// <summary>
        /// >> LessThanExistentialDeposit
        /// </summary>
        LessThanExistentialDeposit,
    }
}