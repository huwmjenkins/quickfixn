// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class QuoteRequest : Message
{
    public const string MsgType = "R";

    public QuoteRequest() : base()
    {
        Header.SetField(new MsgType("R"));
    }

    public QuoteRequest(
            QuoteReqID aQuoteReqID
        ) : this()
    {
        QuoteReqID = aQuoteReqID;
    }

    public QuoteReqID QuoteReqID
    {
        get
        {
            QuoteReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteReqID val) { QuoteReqID = val; }
    public QuoteReqID Get(QuoteReqID val) { GetField(val); return val; }
    public bool IsSet(QuoteReqID val) { return IsSetQuoteReqID(); }
    public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

    public RFQReqID RFQReqID
    {
        get
        {
            RFQReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RFQReqID val) { RFQReqID = val; }
    public RFQReqID Get(RFQReqID val) { GetField(val); return val; }
    public bool IsSet(RFQReqID val) { return IsSetRFQReqID(); }
    public bool IsSetRFQReqID() { return IsSetField(Tags.RFQReqID); }

    public NoRelatedSym NoRelatedSym
    {
        get
        {
            NoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedSym val) { NoRelatedSym = val; }
    public NoRelatedSym Get(NoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(NoRelatedSym val) { return IsSetNoRelatedSym(); }
    public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

    public class NoRelatedSymGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.QuoteType, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TradeOriginationDate, Tags.NoStipulations, Tags.Side, Tags.QuantityType, Tags.OrderQty, Tags.CashOrderQty, Tags.SettlmntTyp, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.ExpireTime, Tags.TransactTime, Tags.Currency, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.PriceType, Tags.Price, Tags.Price2, Tags.YieldType, Tags.Yield, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.QuoteType, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TradeOriginationDate, Tags.NoStipulations, Tags.Side, Tags.QuantityType, Tags.OrderQty, Tags.CashOrderQty, Tags.SettlmntTyp, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.ExpireTime, Tags.TransactTime, Tags.Currency, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.PriceType, Tags.Price, Tags.Price2, Tags.YieldType, Tags.Yield, 0};

        public NoRelatedSymGroup()
          : base(Tags.NoRelatedSym, Tags.Symbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedSymGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public Symbol Symbol
        {
            get
            {
                Symbol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Symbol val) { Symbol = val; }
        public Symbol Get(Symbol val) { GetField(val); return val; }
        public bool IsSet(Symbol val) { return IsSetSymbol(); }
        public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

        public SymbolSfx SymbolSfx
        {
            get
            {
                SymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SymbolSfx val) { SymbolSfx = val; }
        public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
        public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
        public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

        public SecurityID SecurityID
        {
            get
            {
                SecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityID val) { SecurityID = val; }
        public SecurityID Get(SecurityID val) { GetField(val); return val; }
        public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
        public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

        public SecurityIDSource SecurityIDSource
        {
            get
            {
                SecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityIDSource val) { SecurityIDSource = val; }
        public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
        public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

        public NoSecurityAltID NoSecurityAltID
        {
            get
            {
                NoSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoSecurityAltID val) { NoSecurityAltID = val; }
        public NoSecurityAltID Get(NoSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoSecurityAltID val) { return IsSetNoSecurityAltID(); }
        public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

        public Product Product
        {
            get
            {
                Product val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Product val) { Product = val; }
        public Product Get(Product val) { GetField(val); return val; }
        public bool IsSet(Product val) { return IsSetProduct(); }
        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public CFICode CFICode
        {
            get
            {
                CFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CFICode val) { CFICode = val; }
        public CFICode Get(CFICode val) { GetField(val); return val; }
        public bool IsSet(CFICode val) { return IsSetCFICode(); }
        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

        public SecurityType SecurityType
        {
            get
            {
                SecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityType val) { SecurityType = val; }
        public SecurityType Get(SecurityType val) { GetField(val); return val; }
        public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

        public MaturityMonthYear MaturityMonthYear
        {
            get
            {
                MaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
        public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public MaturityDate MaturityDate
        {
            get
            {
                MaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityDate val) { MaturityDate = val; }
        public MaturityDate Get(MaturityDate val) { GetField(val); return val; }
        public bool IsSet(MaturityDate val) { return IsSetMaturityDate(); }
        public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

        public CouponPaymentDate CouponPaymentDate
        {
            get
            {
                CouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponPaymentDate val) { CouponPaymentDate = val; }
        public CouponPaymentDate Get(CouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(CouponPaymentDate val) { return IsSetCouponPaymentDate(); }
        public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

        public IssueDate IssueDate
        {
            get
            {
                IssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IssueDate val) { IssueDate = val; }
        public IssueDate Get(IssueDate val) { GetField(val); return val; }
        public bool IsSet(IssueDate val) { return IsSetIssueDate(); }
        public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

        public RepoCollateralSecurityType RepoCollateralSecurityType
        {
            get
            {
                RepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepoCollateralSecurityType val) { RepoCollateralSecurityType = val; }
        public RepoCollateralSecurityType Get(RepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }
        public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

        public RepurchaseTerm RepurchaseTerm
        {
            get
            {
                RepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepurchaseTerm val) { RepurchaseTerm = val; }
        public RepurchaseTerm Get(RepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(RepurchaseTerm val) { return IsSetRepurchaseTerm(); }
        public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

        public RepurchaseRate RepurchaseRate
        {
            get
            {
                RepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepurchaseRate val) { RepurchaseRate = val; }
        public RepurchaseRate Get(RepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(RepurchaseRate val) { return IsSetRepurchaseRate(); }
        public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

        public Factor Factor
        {
            get
            {
                Factor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Factor val) { Factor = val; }
        public Factor Get(Factor val) { GetField(val); return val; }
        public bool IsSet(Factor val) { return IsSetFactor(); }
        public bool IsSetFactor() { return IsSetField(Tags.Factor); }

        public CreditRating CreditRating
        {
            get
            {
                CreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CreditRating val) { CreditRating = val; }
        public CreditRating Get(CreditRating val) { GetField(val); return val; }
        public bool IsSet(CreditRating val) { return IsSetCreditRating(); }
        public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

        public InstrRegistry InstrRegistry
        {
            get
            {
                InstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrRegistry val) { InstrRegistry = val; }
        public InstrRegistry Get(InstrRegistry val) { GetField(val); return val; }
        public bool IsSet(InstrRegistry val) { return IsSetInstrRegistry(); }
        public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

        public CountryOfIssue CountryOfIssue
        {
            get
            {
                CountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CountryOfIssue val) { CountryOfIssue = val; }
        public CountryOfIssue Get(CountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(CountryOfIssue val) { return IsSetCountryOfIssue(); }
        public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

        public StateOrProvinceOfIssue StateOrProvinceOfIssue
        {
            get
            {
                StateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StateOrProvinceOfIssue val) { StateOrProvinceOfIssue = val; }
        public StateOrProvinceOfIssue Get(StateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }
        public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

        public LocaleOfIssue LocaleOfIssue
        {
            get
            {
                LocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LocaleOfIssue val) { LocaleOfIssue = val; }
        public LocaleOfIssue Get(LocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(LocaleOfIssue val) { return IsSetLocaleOfIssue(); }
        public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

        public RedemptionDate RedemptionDate
        {
            get
            {
                RedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RedemptionDate val) { RedemptionDate = val; }
        public RedemptionDate Get(RedemptionDate val) { GetField(val); return val; }
        public bool IsSet(RedemptionDate val) { return IsSetRedemptionDate(); }
        public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

        public StrikePrice StrikePrice
        {
            get
            {
                StrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePrice val) { StrikePrice = val; }
        public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
        public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public OptAttribute OptAttribute
        {
            get
            {
                OptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptAttribute val) { OptAttribute = val; }
        public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
        public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public ContractMultiplier ContractMultiplier
        {
            get
            {
                ContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractMultiplier val) { ContractMultiplier = val; }
        public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public CouponRate CouponRate
        {
            get
            {
                CouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponRate val) { CouponRate = val; }
        public CouponRate Get(CouponRate val) { GetField(val); return val; }
        public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

        public SecurityExchange SecurityExchange
        {
            get
            {
                SecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityExchange val) { SecurityExchange = val; }
        public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
        public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public Issuer Issuer
        {
            get
            {
                Issuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Issuer val) { Issuer = val; }
        public Issuer Get(Issuer val) { GetField(val); return val; }
        public bool IsSet(Issuer val) { return IsSetIssuer(); }
        public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

        public EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                EncodedIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
        public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public EncodedIssuer EncodedIssuer
        {
            get
            {
                EncodedIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuer val) { EncodedIssuer = val; }
        public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

        public SecurityDesc SecurityDesc
        {
            get
            {
                SecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityDesc val) { SecurityDesc = val; }
        public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
        public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
        public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

        public EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                EncodedSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
        public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                EncodedSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
        public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

        public PrevClosePx PrevClosePx
        {
            get
            {
                PrevClosePx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PrevClosePx val) { PrevClosePx = val; }
        public PrevClosePx Get(PrevClosePx val) { GetField(val); return val; }
        public bool IsSet(PrevClosePx val) { return IsSetPrevClosePx(); }
        public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

        public QuoteRequestType QuoteRequestType
        {
            get
            {
                QuoteRequestType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteRequestType val) { QuoteRequestType = val; }
        public QuoteRequestType Get(QuoteRequestType val) { GetField(val); return val; }
        public bool IsSet(QuoteRequestType val) { return IsSetQuoteRequestType(); }
        public bool IsSetQuoteRequestType() { return IsSetField(Tags.QuoteRequestType); }

        public QuoteType QuoteType
        {
            get
            {
                QuoteType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteType val) { QuoteType = val; }
        public QuoteType Get(QuoteType val) { GetField(val); return val; }
        public bool IsSet(QuoteType val) { return IsSetQuoteType(); }
        public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

        public TradingSessionID TradingSessionID
        {
            get
            {
                TradingSessionID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionID val) { TradingSessionID = val; }
        public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public TradingSessionSubID TradingSessionSubID
        {
            get
            {
                TradingSessionSubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
        public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public TradeOriginationDate TradeOriginationDate
        {
            get
            {
                TradeOriginationDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeOriginationDate val) { TradeOriginationDate = val; }
        public TradeOriginationDate Get(TradeOriginationDate val) { GetField(val); return val; }
        public bool IsSet(TradeOriginationDate val) { return IsSetTradeOriginationDate(); }
        public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

        public NoStipulations NoStipulations
        {
            get
            {
                NoStipulations val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoStipulations val) { NoStipulations = val; }
        public NoStipulations Get(NoStipulations val) { GetField(val); return val; }
        public bool IsSet(NoStipulations val) { return IsSetNoStipulations(); }
        public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

        public Side Side
        {
            get
            {
                Side val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Side val) { Side = val; }
        public Side Get(Side val) { GetField(val); return val; }
        public bool IsSet(Side val) { return IsSetSide(); }
        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public QuantityType QuantityType
        {
            get
            {
                QuantityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuantityType val) { QuantityType = val; }
        public QuantityType Get(QuantityType val) { GetField(val); return val; }
        public bool IsSet(QuantityType val) { return IsSetQuantityType(); }
        public bool IsSetQuantityType() { return IsSetField(Tags.QuantityType); }

        public OrderQty OrderQty
        {
            get
            {
                OrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderQty val) { OrderQty = val; }
        public OrderQty Get(OrderQty val) { GetField(val); return val; }
        public bool IsSet(OrderQty val) { return IsSetOrderQty(); }
        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

        public CashOrderQty CashOrderQty
        {
            get
            {
                CashOrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashOrderQty val) { CashOrderQty = val; }
        public CashOrderQty Get(CashOrderQty val) { GetField(val); return val; }
        public bool IsSet(CashOrderQty val) { return IsSetCashOrderQty(); }
        public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

        public SettlmntTyp SettlmntTyp
        {
            get
            {
                SettlmntTyp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlmntTyp val) { SettlmntTyp = val; }
        public SettlmntTyp Get(SettlmntTyp val) { GetField(val); return val; }
        public bool IsSet(SettlmntTyp val) { return IsSetSettlmntTyp(); }
        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

        public FutSettDate FutSettDate
        {
            get
            {
                FutSettDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FutSettDate val) { FutSettDate = val; }
        public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
        public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public OrdType OrdType
        {
            get
            {
                OrdType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrdType val) { OrdType = val; }
        public OrdType Get(OrdType val) { GetField(val); return val; }
        public bool IsSet(OrdType val) { return IsSetOrdType(); }
        public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

        public FutSettDate2 FutSettDate2
        {
            get
            {
                FutSettDate2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FutSettDate2 val) { FutSettDate2 = val; }
        public FutSettDate2 Get(FutSettDate2 val) { GetField(val); return val; }
        public bool IsSet(FutSettDate2 val) { return IsSetFutSettDate2(); }
        public bool IsSetFutSettDate2() { return IsSetField(Tags.FutSettDate2); }

        public OrderQty2 OrderQty2
        {
            get
            {
                OrderQty2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderQty2 val) { OrderQty2 = val; }
        public OrderQty2 Get(OrderQty2 val) { GetField(val); return val; }
        public bool IsSet(OrderQty2 val) { return IsSetOrderQty2(); }
        public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

        public ExpireTime ExpireTime
        {
            get
            {
                ExpireTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExpireTime val) { ExpireTime = val; }
        public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
        public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

        public TransactTime TransactTime
        {
            get
            {
                TransactTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TransactTime val) { TransactTime = val; }
        public TransactTime Get(TransactTime val) { GetField(val); return val; }
        public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public Currency Currency
        {
            get
            {
                Currency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Currency val) { Currency = val; }
        public Currency Get(Currency val) { GetField(val); return val; }
        public bool IsSet(Currency val) { return IsSetCurrency(); }
        public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

        public Spread Spread
        {
            get
            {
                Spread val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Spread val) { Spread = val; }
        public Spread Get(Spread val) { GetField(val); return val; }
        public bool IsSet(Spread val) { return IsSetSpread(); }
        public bool IsSetSpread() { return IsSetField(Tags.Spread); }

        public BenchmarkCurveCurrency BenchmarkCurveCurrency
        {
            get
            {
                BenchmarkCurveCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BenchmarkCurveCurrency val) { BenchmarkCurveCurrency = val; }
        public BenchmarkCurveCurrency Get(BenchmarkCurveCurrency val) { GetField(val); return val; }
        public bool IsSet(BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }
        public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

        public BenchmarkCurveName BenchmarkCurveName
        {
            get
            {
                BenchmarkCurveName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BenchmarkCurveName val) { BenchmarkCurveName = val; }
        public BenchmarkCurveName Get(BenchmarkCurveName val) { GetField(val); return val; }
        public bool IsSet(BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }
        public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

        public BenchmarkCurvePoint BenchmarkCurvePoint
        {
            get
            {
                BenchmarkCurvePoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BenchmarkCurvePoint val) { BenchmarkCurvePoint = val; }
        public BenchmarkCurvePoint Get(BenchmarkCurvePoint val) { GetField(val); return val; }
        public bool IsSet(BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }
        public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

        public PriceType PriceType
        {
            get
            {
                PriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceType val) { PriceType = val; }
        public PriceType Get(PriceType val) { GetField(val); return val; }
        public bool IsSet(PriceType val) { return IsSetPriceType(); }
        public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

        public Price Price
        {
            get
            {
                Price val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Price val) { Price = val; }
        public Price Get(Price val) { GetField(val); return val; }
        public bool IsSet(Price val) { return IsSetPrice(); }
        public bool IsSetPrice() { return IsSetField(Tags.Price); }

        public Price2 Price2
        {
            get
            {
                Price2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Price2 val) { Price2 = val; }
        public Price2 Get(Price2 val) { GetField(val); return val; }
        public bool IsSet(Price2 val) { return IsSetPrice2(); }
        public bool IsSetPrice2() { return IsSetField(Tags.Price2); }

        public YieldType YieldType
        {
            get
            {
                YieldType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(YieldType val) { YieldType = val; }
        public YieldType Get(YieldType val) { GetField(val); return val; }
        public bool IsSet(YieldType val) { return IsSetYieldType(); }
        public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

        public Yield Yield
        {
            get
            {
                Yield val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Yield val) { Yield = val; }
        public Yield Get(Yield val) { GetField(val); return val; }
        public bool IsSet(Yield val) { return IsSetYield(); }
        public bool IsSetYield() { return IsSetField(Tags.Yield); }

        public class NoSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

            public NoSecurityAltIDGroup()
              : base(Tags.NoSecurityAltID, Tags.SecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SecurityAltID SecurityAltID
            {
                get
                {
                    SecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SecurityAltID val) { SecurityAltID = val; }
            public SecurityAltID Get(SecurityAltID val) { GetField(val); return val; }
            public bool IsSet(SecurityAltID val) { return IsSetSecurityAltID(); }
            public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

            public SecurityAltIDSource SecurityAltIDSource
            {
                get
                {
                    SecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SecurityAltIDSource val) { SecurityAltIDSource = val; }
            public SecurityAltIDSource Get(SecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }
            public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }
        }

        public class NoStipulationsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.StipulationType, Tags.StipulationValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

            public NoStipulationsGroup()
              : base(Tags.NoStipulations, Tags.StipulationType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public StipulationType StipulationType
            {
                get
                {
                    StipulationType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StipulationType val) { StipulationType = val; }
            public StipulationType Get(StipulationType val) { GetField(val); return val; }
            public bool IsSet(StipulationType val) { return IsSetStipulationType(); }
            public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

            public StipulationValue StipulationValue
            {
                get
                {
                    StipulationValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StipulationValue val) { StipulationValue = val; }
            public StipulationValue Get(StipulationValue val) { GetField(val); return val; }
            public bool IsSet(StipulationValue val) { return IsSetStipulationValue(); }
            public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }
        }
    }
}
