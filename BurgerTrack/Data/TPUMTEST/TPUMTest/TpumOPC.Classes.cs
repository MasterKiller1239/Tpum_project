/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TpumOPC
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Order_Employee Object.
        /// </summary>
        public const uint Order_Employee = 16;

        /// <summary>
        /// The identifier for the Order_Customer Object.
        /// </summary>
        public const uint Order_Customer = 17;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the Burger ObjectType.
        /// </summary>
        public const uint Burger = 1;

        /// <summary>
        /// The identifier for the Customer ObjectType.
        /// </summary>
        public const uint Customer = 7;

        /// <summary>
        /// The identifier for the Employee ObjectType.
        /// </summary>
        public const uint Employee = 12;

        /// <summary>
        /// The identifier for the Order ObjectType.
        /// </summary>
        public const uint Order = 14;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the Burger_name Variable.
        /// </summary>
        public const uint Burger_name = 2;

        /// <summary>
        /// The identifier for the Burger_price Variable.
        /// </summary>
        public const uint Burger_price = 3;

        /// <summary>
        /// The identifier for the Burger_description Variable.
        /// </summary>
        public const uint Burger_description = 4;

        /// <summary>
        /// The identifier for the Burger_discount Variable.
        /// </summary>
        public const uint Burger_discount = 5;

        /// <summary>
        /// The identifier for the Burger_image Variable.
        /// </summary>
        public const uint Burger_image = 6;

        /// <summary>
        /// The identifier for the Customer_name Variable.
        /// </summary>
        public const uint Customer_name = 8;

        /// <summary>
        /// The identifier for the Customer_address Variable.
        /// </summary>
        public const uint Customer_address = 9;

        /// <summary>
        /// The identifier for the Customer_email Variable.
        /// </summary>
        public const uint Customer_email = 10;

        /// <summary>
        /// The identifier for the Customer_phone Variable.
        /// </summary>
        public const uint Customer_phone = 11;

        /// <summary>
        /// The identifier for the Employee_name Variable.
        /// </summary>
        public const uint Employee_name = 13;

        /// <summary>
        /// The identifier for the Order_id Variable.
        /// </summary>
        public const uint Order_id = 15;

        /// <summary>
        /// The identifier for the Order_orderTime Variable.
        /// </summary>
        public const uint Order_orderTime = 18;

        /// <summary>
        /// The identifier for the Order_realizationTime Variable.
        /// </summary>
        public const uint Order_realizationTime = 19;

        /// <summary>
        /// The identifier for the Order_burgers Variable.
        /// </summary>
        public const uint Order_burgers = 20;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Order_Employee Object.
        /// </summary>
        public static readonly ExpandedNodeId Order_Employee = new ExpandedNodeId(TpumOPC.Objects.Order_Employee, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order_Customer Object.
        /// </summary>
        public static readonly ExpandedNodeId Order_Customer = new ExpandedNodeId(TpumOPC.Objects.Order_Customer, TpumOPC.Namespaces.TpumOPC);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the Burger ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Burger = new ExpandedNodeId(TpumOPC.ObjectTypes.Burger, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Customer ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Customer = new ExpandedNodeId(TpumOPC.ObjectTypes.Customer, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Employee ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Employee = new ExpandedNodeId(TpumOPC.ObjectTypes.Employee, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Order = new ExpandedNodeId(TpumOPC.ObjectTypes.Order, TpumOPC.Namespaces.TpumOPC);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the Burger_name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Burger_name = new ExpandedNodeId(TpumOPC.Variables.Burger_name, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Burger_price Variable.
        /// </summary>
        public static readonly ExpandedNodeId Burger_price = new ExpandedNodeId(TpumOPC.Variables.Burger_price, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Burger_description Variable.
        /// </summary>
        public static readonly ExpandedNodeId Burger_description = new ExpandedNodeId(TpumOPC.Variables.Burger_description, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Burger_discount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Burger_discount = new ExpandedNodeId(TpumOPC.Variables.Burger_discount, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Burger_image Variable.
        /// </summary>
        public static readonly ExpandedNodeId Burger_image = new ExpandedNodeId(TpumOPC.Variables.Burger_image, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Customer_name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Customer_name = new ExpandedNodeId(TpumOPC.Variables.Customer_name, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Customer_address Variable.
        /// </summary>
        public static readonly ExpandedNodeId Customer_address = new ExpandedNodeId(TpumOPC.Variables.Customer_address, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Customer_email Variable.
        /// </summary>
        public static readonly ExpandedNodeId Customer_email = new ExpandedNodeId(TpumOPC.Variables.Customer_email, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Customer_phone Variable.
        /// </summary>
        public static readonly ExpandedNodeId Customer_phone = new ExpandedNodeId(TpumOPC.Variables.Customer_phone, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Employee_name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Employee_name = new ExpandedNodeId(TpumOPC.Variables.Employee_name, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order_id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Order_id = new ExpandedNodeId(TpumOPC.Variables.Order_id, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order_orderTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Order_orderTime = new ExpandedNodeId(TpumOPC.Variables.Order_orderTime, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order_realizationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Order_realizationTime = new ExpandedNodeId(TpumOPC.Variables.Order_realizationTime, TpumOPC.Namespaces.TpumOPC);

        /// <summary>
        /// The identifier for the Order_burgers Variable.
        /// </summary>
        public static readonly ExpandedNodeId Order_burgers = new ExpandedNodeId(TpumOPC.Variables.Order_burgers, TpumOPC.Namespaces.TpumOPC);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the address component.
        /// </summary>
        public const string address = "address";

        /// <summary>
        /// The BrowseName for the Burger component.
        /// </summary>
        public const string Burger = "Burger";

        /// <summary>
        /// The BrowseName for the burgers component.
        /// </summary>
        public const string burgers = "burgers";

        /// <summary>
        /// The BrowseName for the Customer component.
        /// </summary>
        public const string Customer = "Customer";

        /// <summary>
        /// The BrowseName for the description component.
        /// </summary>
        public const string description = "description";

        /// <summary>
        /// The BrowseName for the discount component.
        /// </summary>
        public const string discount = "discount";

        /// <summary>
        /// The BrowseName for the email component.
        /// </summary>
        public const string email = "email";

        /// <summary>
        /// The BrowseName for the Employee component.
        /// </summary>
        public const string Employee = "Employee";

        /// <summary>
        /// The BrowseName for the id component.
        /// </summary>
        public const string id = "id";

        /// <summary>
        /// The BrowseName for the image component.
        /// </summary>
        public const string image = "image";

        /// <summary>
        /// The BrowseName for the name component.
        /// </summary>
        public const string name = "name";

        /// <summary>
        /// The BrowseName for the Order component.
        /// </summary>
        public const string Order = "Order";

        /// <summary>
        /// The BrowseName for the orderTime component.
        /// </summary>
        public const string orderTime = "orderTime";

        /// <summary>
        /// The BrowseName for the phone component.
        /// </summary>
        public const string phone = "phone";

        /// <summary>
        /// The BrowseName for the price component.
        /// </summary>
        public const string price = "price";

        /// <summary>
        /// The BrowseName for the realizationTime component.
        /// </summary>
        public const string realizationTime = "realizationTime";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the TpumOPC namespace (.NET code namespace is 'TpumOPC').
        /// </summary>
        public const string TpumOPC = "http://example.com/UA/CommServer/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion

    #region BurgerState Class
    #if (!OPCUA_EXCLUDE_BurgerState)
    /// <summary>
    /// Stores an instance of the Burger ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BurgerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BurgerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TpumOPC.ObjectTypes.Burger, TpumOPC.Namespaces.TpumOPC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vZXhhbXBsZS5jb20vVUEvQ29tbVNlcnZlci//////BGCAAAEAAAABAA4AAABC" +
           "dXJnZXJJbnN0YW5jZQEBAQABAQEA/////wUAAAAVYIkKAgAAAAEABAAAAG5hbWUBAQIAAC8APwIAAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABwcmljZQEBAwAALwA/AwAAAAAK/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEACwAAAGRlc2NyaXB0aW9uAQEEAAAvAD8EAAAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAIAAAAZGlzY291bnQBAQUAAC8APwUAAAAACv////8BAf////8AAAAAFWCJCgIAAAABAAUAAABp" +
           "bWFnZQEBBgAALwA/BgAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the name Variable.
        /// </summary>
        public BaseDataVariableState<string> name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <summary>
        /// A description for the price Variable.
        /// </summary>
        public BaseDataVariableState<float> price
        {
            get
            {
                return m_price;
            }

            set
            {
                if (!Object.ReferenceEquals(m_price, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_price = value;
            }
        }

        /// <summary>
        /// A description for the description Variable.
        /// </summary>
        public BaseDataVariableState<string> description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <summary>
        /// A description for the discount Variable.
        /// </summary>
        public BaseDataVariableState<float> discount
        {
            get
            {
                return m_discount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_discount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_discount = value;
            }
        }

        /// <summary>
        /// A description for the image Variable.
        /// </summary>
        public BaseDataVariableState<string> image
        {
            get
            {
                return m_image;
            }

            set
            {
                if (!Object.ReferenceEquals(m_image, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_image = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_price != null)
            {
                children.Add(m_price);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_discount != null)
            {
                children.Add(m_discount);
            }

            if (m_image != null)
            {
                children.Add(m_image);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TpumOPC.BrowseNames.name:
                {
                    if (createOrReplace)
                    {
                        if (name == null)
                        {
                            if (replacement == null)
                            {
                                name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = name;
                    break;
                }

                case TpumOPC.BrowseNames.price:
                {
                    if (createOrReplace)
                    {
                        if (price == null)
                        {
                            if (replacement == null)
                            {
                                price = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                price = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = price;
                    break;
                }

                case TpumOPC.BrowseNames.description:
                {
                    if (createOrReplace)
                    {
                        if (description == null)
                        {
                            if (replacement == null)
                            {
                                description = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                description = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = description;
                    break;
                }

                case TpumOPC.BrowseNames.discount:
                {
                    if (createOrReplace)
                    {
                        if (discount == null)
                        {
                            if (replacement == null)
                            {
                                discount = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                discount = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = discount;
                    break;
                }

                case TpumOPC.BrowseNames.image:
                {
                    if (createOrReplace)
                    {
                        if (image == null)
                        {
                            if (replacement == null)
                            {
                                image = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                image = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = image;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_name;
        private BaseDataVariableState<float> m_price;
        private BaseDataVariableState<string> m_description;
        private BaseDataVariableState<float> m_discount;
        private BaseDataVariableState<string> m_image;
        #endregion
    }
    #endif
    #endregion

    #region CustomerState Class
    #if (!OPCUA_EXCLUDE_CustomerState)
    /// <summary>
    /// Stores an instance of the Customer ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CustomerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CustomerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TpumOPC.ObjectTypes.Customer, TpumOPC.Namespaces.TpumOPC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vZXhhbXBsZS5jb20vVUEvQ29tbVNlcnZlci//////BGCAAAEAAAABABAAAABD" +
           "dXN0b21lckluc3RhbmNlAQEHAAEBBwD/////BAAAABVgiQoCAAAAAQAEAAAAbmFtZQEBCAAALwA/CAAA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAGFkZHJlc3MBAQkAAC8APwkAAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAUAAABlbWFpbAEBCgAALwA/CgAAAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABQAAAHBob25lAQELAAAvAD8LAAAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the name Variable.
        /// </summary>
        public BaseDataVariableState<string> name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <summary>
        /// A description for the address Variable.
        /// </summary>
        public BaseDataVariableState<string> address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
            }
        }

        /// <summary>
        /// A description for the email Variable.
        /// </summary>
        public BaseDataVariableState<string> email
        {
            get
            {
                return m_email;
            }

            set
            {
                if (!Object.ReferenceEquals(m_email, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_email = value;
            }
        }

        /// <summary>
        /// A description for the phone Variable.
        /// </summary>
        public BaseDataVariableState<string> phone
        {
            get
            {
                return m_phone;
            }

            set
            {
                if (!Object.ReferenceEquals(m_phone, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_phone = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_address != null)
            {
                children.Add(m_address);
            }

            if (m_email != null)
            {
                children.Add(m_email);
            }

            if (m_phone != null)
            {
                children.Add(m_phone);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TpumOPC.BrowseNames.name:
                {
                    if (createOrReplace)
                    {
                        if (name == null)
                        {
                            if (replacement == null)
                            {
                                name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = name;
                    break;
                }

                case TpumOPC.BrowseNames.address:
                {
                    if (createOrReplace)
                    {
                        if (address == null)
                        {
                            if (replacement == null)
                            {
                                address = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                address = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = address;
                    break;
                }

                case TpumOPC.BrowseNames.email:
                {
                    if (createOrReplace)
                    {
                        if (email == null)
                        {
                            if (replacement == null)
                            {
                                email = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                email = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = email;
                    break;
                }

                case TpumOPC.BrowseNames.phone:
                {
                    if (createOrReplace)
                    {
                        if (phone == null)
                        {
                            if (replacement == null)
                            {
                                phone = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                phone = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = phone;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_name;
        private BaseDataVariableState<string> m_address;
        private BaseDataVariableState<string> m_email;
        private BaseDataVariableState<string> m_phone;
        #endregion
    }
    #endif
    #endregion

    #region EmployeeState Class
    #if (!OPCUA_EXCLUDE_EmployeeState)
    /// <summary>
    /// Stores an instance of the Employee ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EmployeeState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EmployeeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TpumOPC.ObjectTypes.Employee, TpumOPC.Namespaces.TpumOPC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vZXhhbXBsZS5jb20vVUEvQ29tbVNlcnZlci//////BGCAAAEAAAABABAAAABF" +
           "bXBsb3llZUluc3RhbmNlAQEMAAEBDAD/////AQAAABVgiQoCAAAAAQAEAAAAbmFtZQEBDQAALwA/DQAA" +
           "AAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the name Variable.
        /// </summary>
        public BaseDataVariableState<string> name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TpumOPC.BrowseNames.name:
                {
                    if (createOrReplace)
                    {
                        if (name == null)
                        {
                            if (replacement == null)
                            {
                                name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = name;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_name;
        #endregion
    }
    #endif
    #endregion

    #region OrderState Class
    #if (!OPCUA_EXCLUDE_OrderState)
    /// <summary>
    /// Stores an instance of the Order ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OrderState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OrderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TpumOPC.ObjectTypes.Order, TpumOPC.Namespaces.TpumOPC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vZXhhbXBsZS5jb20vVUEvQ29tbVNlcnZlci//////BGCAAAEAAAABAA0AAABP" +
           "cmRlckluc3RhbmNlAQEOAAEBDgD/////BgAAABVgiQoCAAAAAQACAAAAaWQBAQ8AAC8APw8AAAAADv//" +
           "//8BAf////8AAAAABGCACgEAAAABAAgAAABFbXBsb3llZQEBEAAALwA6EAAAAP////8AAAAABGCACgEA" +
           "AAABAAgAAABDdXN0b21lcgEBEQAALwA6EQAAAP////8AAAAAFWCJCgIAAAABAAkAAABvcmRlclRpbWUB" +
           "ARIAAC8APxIAAAAADf////8BAf////8AAAAAFWCJCgIAAAABAA8AAAByZWFsaXphdGlvblRpbWUBARMA" +
           "AC8APxMAAAAAG/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABidXJnZXJzAQEUAAAvAD8UAAAAAAv/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the id Variable.
        /// </summary>
        public BaseDataVariableState<Guid> id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <summary>
        /// A description for the Employee Object.
        /// </summary>
        public BaseObjectState Employee
        {
            get
            {
                return m_employee;
            }

            set
            {
                if (!Object.ReferenceEquals(m_employee, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_employee = value;
            }
        }

        /// <summary>
        /// A description for the Customer Object.
        /// </summary>
        public BaseObjectState Customer
        {
            get
            {
                return m_customer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_customer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_customer = value;
            }
        }

        /// <summary>
        /// A description for the orderTime Variable.
        /// </summary>
        public BaseDataVariableState<DateTime> orderTime
        {
            get
            {
                return m_orderTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_orderTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_orderTime = value;
            }
        }

        /// <summary>
        /// A description for the realizationTime Variable.
        /// </summary>
        public BaseDataVariableState realizationTime
        {
            get
            {
                return m_realizationTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_realizationTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_realizationTime = value;
            }
        }

        /// <summary>
        /// A description for the burgers Variable.
        /// </summary>
        public BaseDataVariableState<double> burgers
        {
            get
            {
                return m_burgers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_burgers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_burgers = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_employee != null)
            {
                children.Add(m_employee);
            }

            if (m_customer != null)
            {
                children.Add(m_customer);
            }

            if (m_orderTime != null)
            {
                children.Add(m_orderTime);
            }

            if (m_realizationTime != null)
            {
                children.Add(m_realizationTime);
            }

            if (m_burgers != null)
            {
                children.Add(m_burgers);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TpumOPC.BrowseNames.id:
                {
                    if (createOrReplace)
                    {
                        if (id == null)
                        {
                            if (replacement == null)
                            {
                                id = new BaseDataVariableState<Guid>(this);
                            }
                            else
                            {
                                id = (BaseDataVariableState<Guid>)replacement;
                            }
                        }
                    }

                    instance = id;
                    break;
                }

                case TpumOPC.BrowseNames.Employee:
                {
                    if (createOrReplace)
                    {
                        if (Employee == null)
                        {
                            if (replacement == null)
                            {
                                Employee = new BaseObjectState(this);
                            }
                            else
                            {
                                Employee = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Employee;
                    break;
                }

                case TpumOPC.BrowseNames.Customer:
                {
                    if (createOrReplace)
                    {
                        if (Customer == null)
                        {
                            if (replacement == null)
                            {
                                Customer = new BaseObjectState(this);
                            }
                            else
                            {
                                Customer = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Customer;
                    break;
                }

                case TpumOPC.BrowseNames.orderTime:
                {
                    if (createOrReplace)
                    {
                        if (orderTime == null)
                        {
                            if (replacement == null)
                            {
                                orderTime = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                orderTime = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = orderTime;
                    break;
                }

                case TpumOPC.BrowseNames.realizationTime:
                {
                    if (createOrReplace)
                    {
                        if (realizationTime == null)
                        {
                            if (replacement == null)
                            {
                                realizationTime = new BaseDataVariableState(this);
                            }
                            else
                            {
                                realizationTime = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = realizationTime;
                    break;
                }

                case TpumOPC.BrowseNames.burgers:
                {
                    if (createOrReplace)
                    {
                        if (burgers == null)
                        {
                            if (replacement == null)
                            {
                                burgers = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                burgers = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = burgers;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<Guid> m_id;
        private BaseObjectState m_employee;
        private BaseObjectState m_customer;
        private BaseDataVariableState<DateTime> m_orderTime;
        private BaseDataVariableState m_realizationTime;
        private BaseDataVariableState<double> m_burgers;
        #endregion
    }
    #endif
    #endregion
}