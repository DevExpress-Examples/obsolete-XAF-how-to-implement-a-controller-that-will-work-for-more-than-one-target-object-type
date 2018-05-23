using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public interface ISupportDemoAction { }
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("I have the Demo Action")]
    public class DomainObject1 : BaseObject, ISupportDemoAction {
        public DomainObject1(Session session) : base(session) { }
    }
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("I have the Demo Action")]
    public class DomainObject2 : BaseObject, ISupportDemoAction {
        public DomainObject2(Session session) : base(session) { }
    }
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("I don't have the Demo Action")]
    public class DomainObject3 : BaseObject {
        public DomainObject3(Session session) : base(session) { }
    }
}
