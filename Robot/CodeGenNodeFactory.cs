//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace CodeGenerated
{
    public class CodeGenNodeFactory
    {
        public static CodeGenObjectTypeBase CreateObject(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_ObjectType_RobotType_1399168976_0")
                return new ObjectType_RobotType_1399168976_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }

        public static CodeGenVariableTypeBase CreateVariable(string szBrowseName,
                                                              string fileNoExtension,
                                                              string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                              string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                              string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_VariableType_RuntimeHours_1742712885_0")
                return new VariableType_RuntimeHours_1742712885_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_Manufacturer_98866125_0")
                return new VariableType_Manufacturer_98866125_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_PowerOn_1065183424_0")
                return new VariableType_PowerOn_1065183424_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }
        
        public static CodeGenMethodTypeBase CreateMethod(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_MethodType_Start_1055650632_0")
                return new MethodType_Start_1055650632_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_MethodType_Stop_1831099175_0")
                return new MethodType_Stop_1831099175_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }       
    }
}
