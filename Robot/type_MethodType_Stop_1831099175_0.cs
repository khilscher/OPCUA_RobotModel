//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: Stop


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class MethodType_Stop_1831099175_0 : CodeGenMethodTypeBase
    {        
        public MethodType_Stop_1831099175_0(string browseName,
                               string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                               string nodeId, ushort namespaceIndex, IdType nodeIdType,
                               string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType
                               ) : base(browseName, 
                                        typeId, typeNamespaceIndex, typeNodeIdType,
                                        nodeId, namespaceIndex, nodeIdType,
                                        parentNodeId, parentNamespaceIndex, parentNodeIdType)
        {
            //constructor
        }
        
        public override bool Initialize(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                        CodeGenNodeManager addressSpaceMgr)
        {
            Console.WriteLine("MethodType_Stop_1831099175_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;
            
            // Set attributes
            this.GetNode().BrowseName  = "Stop";
            this.GetNode().DisplayName = "Stop";
            this.GetNode().Description = "";
            this.GetNode().Executable  = true;
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
            return success;
        }

        public override MethodState GetNode()
        {
            return m_node;
        }

        public override void SetNode(MethodState node)
        {
            m_node  = node;
            m_inode = node;
        }
    }
}
