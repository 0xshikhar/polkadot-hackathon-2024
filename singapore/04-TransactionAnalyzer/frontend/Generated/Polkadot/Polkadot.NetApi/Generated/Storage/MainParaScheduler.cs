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


namespace Polkadot.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> ParaSchedulerStorage
    /// </summary>
    public sealed class ParaSchedulerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ParaSchedulerStorage Constructor
        /// </summary>
        public ParaSchedulerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaScheduler", "ValidatorGroups"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaScheduler", "AvailabilityCores"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.scheduler.pallet.EnumCoreOccupied>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaScheduler", "SessionStartBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaScheduler", "ClaimQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Polkadot.NetApi.Generated.Types.Base.BTreeMapT4)));
        }
        
        /// <summary>
        /// >> ValidatorGroupsParams
        ///  All the validator groups. One for each core. Indices are into `ActiveValidators` - not the
        ///  broader set of Polkadot validators, but instead just the subset used for parachains during
        ///  this session.
        /// 
        ///  Bound: The number of cores is the sum of the numbers of parachains and parathread
        ///  multiplexers. Reasonably, 100-1000. The dominant factor is the number of validators: safe
        ///  upper bound at 10k.
        /// </summary>
        public static string ValidatorGroupsParams()
        {
            return RequestGenerator.GetStorage("ParaScheduler", "ValidatorGroups", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ValidatorGroupsDefault
        /// Default value as hex string
        /// </summary>
        public static string ValidatorGroupsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ValidatorGroups
        ///  All the validator groups. One for each core. Indices are into `ActiveValidators` - not the
        ///  broader set of Polkadot validators, but instead just the subset used for parachains during
        ///  this session.
        /// 
        ///  Bound: The number of cores is the sum of the numbers of parachains and parathread
        ///  multiplexers. Reasonably, 100-1000. The dominant factor is the number of validators: safe
        ///  upper bound at 10k.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex>>> ValidatorGroups(string blockhash, CancellationToken token)
        {
            string parameters = ParaSchedulerStorage.ValidatorGroupsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex>>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AvailabilityCoresParams
        ///  One entry for each availability core. Entries are `None` if the core is not currently
        ///  occupied. Can be temporarily `Some` if scheduled but not occupied.
        ///  The i'th parachain belongs to the i'th core, with the remaining cores all being
        ///  parathread-multiplexers.
        /// 
        ///  Bounded by the maximum of either of these two values:
        ///    * The number of parachains and parathread multiplexers
        ///    * The number of validators divided by `configuration.max_validators_per_core`.
        /// </summary>
        public static string AvailabilityCoresParams()
        {
            return RequestGenerator.GetStorage("ParaScheduler", "AvailabilityCores", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AvailabilityCoresDefault
        /// Default value as hex string
        /// </summary>
        public static string AvailabilityCoresDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AvailabilityCores
        ///  One entry for each availability core. Entries are `None` if the core is not currently
        ///  occupied. Can be temporarily `Some` if scheduled but not occupied.
        ///  The i'th parachain belongs to the i'th core, with the remaining cores all being
        ///  parathread-multiplexers.
        /// 
        ///  Bounded by the maximum of either of these two values:
        ///    * The number of parachains and parathread multiplexers
        ///    * The number of validators divided by `configuration.max_validators_per_core`.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.scheduler.pallet.EnumCoreOccupied>> AvailabilityCores(string blockhash, CancellationToken token)
        {
            string parameters = ParaSchedulerStorage.AvailabilityCoresParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.scheduler.pallet.EnumCoreOccupied>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SessionStartBlockParams
        ///  The block number where the session start occurred. Used to track how many group rotations
        ///  have occurred.
        /// 
        ///  Note that in the context of parachains modules the session change is signaled during
        ///  the block and enacted at the end of the block (at the finalization stage, to be exact).
        ///  Thus for all intents and purposes the effect of the session change is observed at the
        ///  block following the session change, block number of which we save in this storage value.
        /// </summary>
        public static string SessionStartBlockParams()
        {
            return RequestGenerator.GetStorage("ParaScheduler", "SessionStartBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SessionStartBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string SessionStartBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> SessionStartBlock
        ///  The block number where the session start occurred. Used to track how many group rotations
        ///  have occurred.
        /// 
        ///  Note that in the context of parachains modules the session change is signaled during
        ///  the block and enacted at the end of the block (at the finalization stage, to be exact).
        ///  Thus for all intents and purposes the effect of the session change is observed at the
        ///  block following the session change, block number of which we save in this storage value.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SessionStartBlock(string blockhash, CancellationToken token)
        {
            string parameters = ParaSchedulerStorage.SessionStartBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ClaimQueueParams
        ///  One entry for each availability core. The `VecDeque` represents the assignments to be
        ///  scheduled on that core. `None` is used to signal to not schedule the next para of the core
        ///  as there is one currently being scheduled. Not using `None` here would overwrite the
        ///  `CoreState` in the runtime API. The value contained here will not be valid after the end of
        ///  a block. Runtime APIs should be used to determine scheduled cores/ for the upcoming block.
        /// </summary>
        public static string ClaimQueueParams()
        {
            return RequestGenerator.GetStorage("ParaScheduler", "ClaimQueue", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ClaimQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string ClaimQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ClaimQueue
        ///  One entry for each availability core. The `VecDeque` represents the assignments to be
        ///  scheduled on that core. `None` is used to signal to not schedule the next para of the core
        ///  as there is one currently being scheduled. Not using `None` here would overwrite the
        ///  `CoreState` in the runtime API. The value contained here will not be valid after the end of
        ///  a block. Runtime APIs should be used to determine scheduled cores/ for the upcoming block.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Types.Base.BTreeMapT4> ClaimQueue(string blockhash, CancellationToken token)
        {
            string parameters = ParaSchedulerStorage.ClaimQueueParams();
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Types.Base.BTreeMapT4>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ParaSchedulerCalls
    /// </summary>
    public sealed class ParaSchedulerCalls
    {
    }
    
    /// <summary>
    /// >> ParaSchedulerConstants
    /// </summary>
    public sealed class ParaSchedulerConstants
    {
    }
}