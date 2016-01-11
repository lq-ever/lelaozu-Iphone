// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface SendSecurityCodeController : UIViewController {
	UIButton *_btn_next;
	UIButton *_btn_sendCode;
	UILabel *_lbl_customPhone;
	UILabel *_lbl_sendCodeStatusShow;
	UIScrollView *_scrollView;
	UITextField *_txt_phoneNumber;
	UITextField *_txt_securityCode;
}

@property (nonatomic, retain) IBOutlet UIButton *btn_next;

@property (nonatomic, retain) IBOutlet UIButton *btn_sendCode;

@property (nonatomic, retain) IBOutlet UILabel *lbl_customPhone;

@property (nonatomic, retain) IBOutlet UILabel *lbl_sendCodeStatusShow;

@property (nonatomic, retain) IBOutlet UIScrollView *scrollView;

@property (nonatomic, retain) IBOutlet UITextField *txt_phoneNumber;

@property (nonatomic, retain) IBOutlet UITextField *txt_securityCode;

@end
