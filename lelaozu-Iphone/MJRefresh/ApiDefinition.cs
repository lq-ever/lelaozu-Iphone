using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MJRefresh
{
    // @interface MJRefresh (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefresh
    {
        // @property (nonatomic, strong) MJRefreshHeader * header;
        //        [Export("header", ArgumentSemantic.Strong)]
        //        MJRefreshHeader Header { get; set; }

        [Export("header")]
        MJRefreshHeader GetHeader();

        [Export("setHeader:")]
        void SetHeader(MJRefreshHeader header);


        // @property (nonatomic, strong) MJRefreshFooter * footer;
        //        [Export("footer", ArgumentSemantic.Strong)]
        //        MJRefreshFooter Footer { get; set; }

        [Export("footer")]
        MJRefreshFooter GetFooter();

        [Export("setFooter:")]
        void SetFooter(MJRefreshFooter footer);

        // -(NSInteger)totalDataCount;
        [Export("totalDataCount")]
        //[Verify(MethodToProperty)]
        nint GetTotalDataCount();

        // @property (copy, nonatomic) void (^reloadDataBlock)(NSInteger);
        //        [Export("reloadDataBlock", ArgumentSemantic.Copy)]
        //        Action<nint> ReloadDataBlock { get; set; }

        [Export("reloadDataBlock")]
        Action<nint> GetReloadDataBlock();

        [Export("setReloadDataBlock:")]
        void SetReloadDataBlock(Action<nint>  action);
    }

     
    // typedef void (^MJRefreshComponentRefreshingBlock)();
    delegate void MJRefreshComponentRefreshingBlock();

    // @interface MJRefreshComponent : UIView
    [BaseType(typeof(UIView))]
    interface MJRefreshComponent
    {
        // @property (copy, nonatomic) MJRefreshComponentRefreshingBlock refreshingBlock;
        [Export("refreshingBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentRefreshingBlock RefreshingBlock { get; set; }

        // -(void)setRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("setRefreshingTarget:refreshingAction:")]
        void SetRefreshingTarget(NSObject target, Selector action);

        // @property (nonatomic, weak) id _Nullable refreshingTarget;
        [NullAllowed, Export("refreshingTarget", ArgumentSemantic.Weak)]
        NSObject RefreshingTarget { get; set; }

        // @property (assign, nonatomic) SEL refreshingAction;
        [Export("refreshingAction", ArgumentSemantic.Assign)]
        Selector RefreshingAction { get; set; }

        // -(void)executeRefreshingCallback;
        [Export("executeRefreshingCallback")]
        void ExecuteRefreshingCallback();

        // -(void)beginRefreshing;
        [Export("beginRefreshing")]
        void BeginRefreshing();

        // -(void)endRefreshing;
        [Export("endRefreshing")]
        void EndRefreshing();

        // -(BOOL)isRefreshing;
        [Export("isRefreshing")]
        //[Verify(MethodToProperty)]
        bool IsRefreshing { get; }

        // @property (assign, nonatomic) MJRefreshState state;
        [Export("state", ArgumentSemantic.Assign)]
        MJRefreshState State { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets scrollViewOriginalInset;
        [Export("scrollViewOriginalInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ScrollViewOriginalInset { get; }

        // @property (readonly, nonatomic, weak) UIScrollView * _Nullable scrollView;
        [NullAllowed, Export("scrollView", ArgumentSemantic.Weak)]
        UIScrollView ScrollView { get; }

        // -(void)prepare;
        [Export("prepare")]
        void Prepare();

        // -(void)placeSubviews;
        [Export("placeSubviews")]
        void PlaceSubviews();

        // -(void)scrollViewContentOffsetDidChange:(NSDictionary *)change;
        [Export("scrollViewContentOffsetDidChange:")]
        void ScrollViewContentOffsetDidChange(NSDictionary change);

        // -(void)scrollViewContentSizeDidChange:(NSDictionary *)change;
        [Export("scrollViewContentSizeDidChange:")]
        void ScrollViewContentSizeDidChange(NSDictionary change);

        // -(void)scrollViewPanStateDidChange:(NSDictionary *)change;
        [Export("scrollViewPanStateDidChange:")]
        void ScrollViewPanStateDidChange(NSDictionary change);

        // @property (assign, nonatomic) CGFloat pullingPercent;
        [Export("pullingPercent")]
        nfloat PullingPercent { get; set; }

        // @property (getter = isAutoChangeAlpha, assign, nonatomic) BOOL autoChangeAlpha __attribute__((availability(ios, introduced=2_0, deprecated=2_0)));
        //        [Introduced(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //        [Deprecated(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //        [Export("autoChangeAlpha")]
        //        bool AutoChangeAlpha { [Bind ("isAutoChangeAlpha")] get; set; }

        // @property (getter = isAutomaticallyChangeAlpha, assign, nonatomic) BOOL automaticallyChangeAlpha;
        [Export("automaticallyChangeAlpha")]
        bool AutomaticallyChangeAlpha { [Bind ("isAutomaticallyChangeAlpha")] get; set; }
    }

    // @interface MJRefresh (UILabel)
    [Category]
    [BaseType(typeof(UILabel))]
    interface UILabel_MJRefresh
    {
        // +(instancetype)label;
        [Static]
        [Export("label")]
        UILabel Label();
    }

    // @interface MJRefreshHeader : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshHeader
    {
        // +(instancetype)headerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("headerWithRefreshingBlock:")]
        MJRefreshHeader HeaderWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        // +(instancetype)headerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("headerWithRefreshingTarget:refreshingAction:")]
        MJRefreshHeader HeaderWithRefreshingTarget(NSObject target, Selector action);

        // @property (copy, nonatomic) NSString * lastUpdatedTimeKey;
        [Export("lastUpdatedTimeKey")]
        string LastUpdatedTimeKey { get; set; }

        // @property (readonly, nonatomic, strong) NSDate * lastUpdatedTime;
        [Export("lastUpdatedTime", ArgumentSemantic.Strong)]
        NSDate LastUpdatedTime { get; }

        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetTop;
        [Export("ignoredScrollViewContentInsetTop")]
        nfloat IgnoredScrollViewContentInsetTop { get; set; }
    }
 

    // @interface MJExtension (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_MJExtension
    {
        // @property (assign, nonatomic) CGFloat mj_x;
        [Export("mj_x")]
        nfloat GetMj_x();

        [Export("setMj_x:")]
        void SetMj_x(nfloat value);

        
        // @property (assign, nonatomic) CGFloat mj_h;
        [Export("mj_h")]
        nfloat GetMj_h();

        [Export("setMj_h:")]
        void SetMj_h(nfloat value);

        // @property (assign, nonatomic) CGSize mj_size;
        
    }

    // @interface MJRefreshStateHeader : MJRefreshHeader
    [BaseType(typeof(MJRefreshHeader))]
    interface MJRefreshStateHeader
    {
        // @property (copy, nonatomic) NSString * (^lastUpdatedTimeText)(NSDate *);
        [Export("lastUpdatedTimeText", ArgumentSemantic.Copy)]
        Func<NSDate, NSString> LastUpdatedTimeText { get; set; }

        // @property (readonly, nonatomic, weak) UILabel * _Nullable lastUpdatedTimeLabel;
        [NullAllowed, Export("lastUpdatedTimeLabel", ArgumentSemantic.Weak)]
        UILabel LastUpdatedTimeLabel { get; }

        // @property (readonly, nonatomic, weak) UILabel * _Nullable stateLabel;
        [NullAllowed, Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);
    }

    // @interface MJRefreshNormalHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshNormalHeader
    {
        // @property (readonly, nonatomic, weak) UIImageView * _Nullable arrowView;
        [NullAllowed, Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshGifHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshGifHeader
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(NSObject[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(NSObject[] images, MJRefreshState state);
    }

    // @interface MJRefreshFooter : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshFooter
    {
        // +(instancetype)footerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("footerWithRefreshingBlock:")]
        MJRefreshFooter FooterWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        // +(instancetype)footerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("footerWithRefreshingTarget:refreshingAction:")]
        MJRefreshFooter FooterWithRefreshingTarget(NSObject target, Selector action);

        // -(void)endRefreshingWithNoMoreData;
        [Export("endRefreshingWithNoMoreData")]
        void EndRefreshingWithNoMoreData();

        // -(void)noticeNoMoreData __attribute__((availability(ios, introduced=2_0, deprecated=2_0)));
        //        [Introduced(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
        //        [Deprecated(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
        //        [Export("noticeNoMoreData")]
        //        void NoticeNoMoreData();

        // -(void)resetNoMoreData;
        [Export("resetNoMoreData")]
        void ResetNoMoreData();

        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetBottom;
        [Export("ignoredScrollViewContentInsetBottom")]
        nfloat IgnoredScrollViewContentInsetBottom { get; set; }

        // @property (getter = isAutomaticallyHidden, assign, nonatomic) BOOL automaticallyHidden;
        [Export("automaticallyHidden")]
        bool AutomaticallyHidden { [Bind ("isAutomaticallyHidden")] get; set; }
    }

    // @interface MJRefreshBackFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshBackFooter
    {
    }

    // @interface MJRefreshBackStateFooter : MJRefreshBackFooter
    [BaseType(typeof(MJRefreshBackFooter))]
    interface MJRefreshBackStateFooter
    {
        // @property (readonly, nonatomic, weak) UILabel * _Nullable stateLabel;
        [NullAllowed, Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        // -(NSString *)titleForState:(MJRefreshState)state;
        [Export("titleForState:")]
        string TitleForState(MJRefreshState state);
    }

    // @interface MJRefreshBackNormalFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackNormalFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * _Nullable arrowView;
        [NullAllowed, Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshBackGifFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackGifFooter
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshState state);
    }

    // @interface MJRefreshAutoFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshAutoFooter
    {
        // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
        [Export("automaticallyRefresh")]
        bool AutomaticallyRefresh { [Bind ("isAutomaticallyRefresh")] get; set; }

        // @property (assign, nonatomic) CGFloat appearencePercentTriggerAutoRefresh __attribute__((availability(ios, introduced=2_0, deprecated=2_0)));
        //        [Introduced(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //        [Deprecated(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //        [Export("appearencePercentTriggerAutoRefresh")]
        //        nfloat AppearencePercentTriggerAutoRefresh { get; set; }

        // @property (assign, nonatomic) CGFloat triggerAutomaticallyRefreshPercent;
        [Export("triggerAutomaticallyRefreshPercent")]
        nfloat TriggerAutomaticallyRefreshPercent { get; set; }
    }

    // @interface MJRefreshAutoStateFooter : MJRefreshAutoFooter
    [BaseType(typeof(MJRefreshAutoFooter))]
    interface MJRefreshAutoStateFooter
    {
        // @property (readonly, nonatomic, weak) UILabel * _Nullable stateLabel;
        [NullAllowed, Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        // @property (getter = isRefreshingTitleHidden, assign, nonatomic) BOOL refreshingTitleHidden;
        [Export("refreshingTitleHidden")]
        bool RefreshingTitleHidden { [Bind ("isRefreshingTitleHidden")] get; set; }
    }

    // @interface MJRefreshAutoNormalFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoNormalFooter
    {
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshAutoGifFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoGifFooter
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //[Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshState state);
    }
}
