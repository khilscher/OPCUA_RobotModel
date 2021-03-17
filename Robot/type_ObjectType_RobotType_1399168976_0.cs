//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: RobotType


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class ObjectType_RobotType_1399168976_0 : CodeGenObjectTypeBase
    {        
        public ObjectType_RobotType_1399168976_0(string browseName,
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
            Console.WriteLine("ObjectType_RobotType_1399168976_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;

            // Set attributes
            this.GetNode().BrowseName  = "RobotType";
            this.GetNode().DisplayName = "RobotType";
            this.GetNode().Description = "";
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
                                        
            //Create Children objects
            
            
            //Create Children variables
            
            {
            string childBrowseName = "RuntimeHours";
    string childFileNoExtension = "type_VariableType_RuntimeHours_1742712885_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "27";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "RuntimeHours";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("RobotModel");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_RuntimeHours_1742712885_0 = (VariableType_RuntimeHours_1742712885_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_RuntimeHours_1742712885_0 local = var_RuntimeHours_1742712885_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "PowerOn";
    string childFileNoExtension = "type_VariableType_PowerOn_1065183424_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "1";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "PowerOn";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("RobotModel");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_PowerOn_1065183424_0 = (VariableType_PowerOn_1065183424_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_PowerOn_1065183424_0 local = var_PowerOn_1065183424_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            
            //Create Children properties
            
            {
            string childBrowseName = "Manufacturer";
    string childFileNoExtension = "type_VariableType_Manufacturer_98866125_0";
    string childTypeDefId = "68";
    ushort childTypeDefNamespaceIndex = 0;
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "Manufacturer";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("RobotModel");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Manufacturer_98866125_0 = (VariableType_Manufacturer_98866125_0)                                                                                            
            (m_addressSpaceMgr.CreateProperty(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Manufacturer_98866125_0 local = var_Manufacturer_98866125_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());

            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            
            //Create Children methods
            
            {
            string childBrowseName = "Stop";
    string childFileNoExtension = "type_MethodType_Stop_1831099175_0";
    string childSourceId = "Stop";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("RobotModel");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    method_Stop_1831099175_0 = (MethodType_Stop_1831099175_0)
                         (m_addressSpaceMgr.CreateMethod(childrenIDMap,                                                             
                         this.GetNode(), childFileNoExtension, childBrowseName,                                                     
                         childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,                 
	                        newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType,  
  	                    m_nodeId, m_namespaceIndex, m_nodeIdType));                                                                
    MethodType_Stop_1831099175_0 local = method_Stop_1831099175_0;
    MethodState method =  local.GetNode();
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, method);

            method.OnCallMethod = CodeGenMethodHandler.GetInstance().OnAddCall;
            }
            
            {
            string childBrowseName = "Start";
    string childFileNoExtension = "type_MethodType_Start_1055650632_0";
    string childSourceId = "Start";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("RobotModel");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    method_Start_1055650632_0 = (MethodType_Start_1055650632_0)
                         (m_addressSpaceMgr.CreateMethod(childrenIDMap,                                                             
                         this.GetNode(), childFileNoExtension, childBrowseName,                                                     
                         childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,                 
	                        newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType,  
  	                    m_nodeId, m_namespaceIndex, m_nodeIdType));                                                                
    MethodType_Start_1055650632_0 local = method_Start_1055650632_0;
    MethodState method =  local.GetNode();
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, method);

            method.OnCallMethod = CodeGenMethodHandler.GetInstance().OnAddCall;
            }
            
            
            
            return success;
        }

        public override BaseObjectState GetNode()
        {
            return m_node;
        }

        public override void SetNode(BaseObjectState node)
        {
            m_node  = node;
            m_inode = node;
        }
        
        #region Public Fields
        /* Children objects */  
        

            /* Children variables */
            public VariableType_RuntimeHours_1742712885_0 var_RuntimeHours_1742712885_0;
    public VariableType_PowerOn_1065183424_0 var_PowerOn_1065183424_0;


            /* Children properties */
            public VariableType_Manufacturer_98866125_0 var_Manufacturer_98866125_0;


            /* Children methods */
            public MethodType_Stop_1831099175_0 method_Stop_1831099175_0;
    public MethodType_Start_1055650632_0 method_Start_1055650632_0;

        #endregion
    }
}
