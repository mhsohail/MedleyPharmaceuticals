using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedleyPharmaceuticals
{
    public class MedleyDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<MedleyModelContainer>
    {

        MedleyModelContainer context = new MedleyModelContainer();

        protected override void Seed(MedleyModelContainer context)
        {
            base.Seed(context);
        }

        //public void Initialize()
        //{
        //    List<ReceivedGood> goods = new List<ReceivedGood>();
        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Propyl Paraben Sodium",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 10,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Propyl Glycol (P/G)",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 36,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Red Lake Color",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 70,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Silicon Oil",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 45,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "SLS",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 60,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Sodium Benzoate",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 20,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    goods.Add(new ReceivedGood
        //    {
        //        MaterialName = "Strawberry Flavour",
        //        ReceivingDate = DateTime.Parse("01-01-2015").Date,
        //        BatchNo = "123",
        //        MfgDate = DateTime.Parse("01-01-2015").Date,
        //        ExpDate = DateTime.Parse("01-01-2015").Date,
        //        GRNNo = "234",
        //        NoOfCartons = 85,
        //        QuantityReceived = "6",
        //        ReferenceNo = "765",
        //        Supplier = "SunEdison"
        //    });

        //    context.ReceivedGoods.AddRange(goods);
        //    context.SaveChanges();
        //}

        //public void Truncate()
        //{

        //    foreach (var product in context.ReceivedGoods.ToList())
        //    {
        //        context.ReceivedGoods.Local.Remove((ReceivedGood)product);    
        //    }
        //    context.SaveChanges();
        //}

    }
}
