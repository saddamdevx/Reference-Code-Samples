﻿using FacePinPoint.Entities.Request;
using FacePinPoint.Entities.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePinPoint.Repository.IRepository
{
    public interface IAccountRepository
    {
        IRestResponse UserCreate(usercreate userDetail);
        Task<LoginResponse> Login(UserLogin userLogin);
        Task<UserDetailResponse> GetUserDetailByUserEmail(string email);
        Task<EmailExistsResponse> EmailExists(string email);
        BaseResponse SaveUserImage(UserImageRequest userImageRequest);
        Task<SignUpReposne> SignUpUser(SignUpDetailsRequest signUpDetails);
        Task<AccountDetailReposne> SaveAccountDetail(AccountDetail accountDetail);
        Task<BaseResponse> EnrollUserIDPhoto(PhotoDetailRequest photoDetail);
        Task<SavePaymentReponse> SavePaymentDetail(PaymentDetailRequest paymentDetailsRequest);
        Task<LoggedUserDetailResponse> GetLoggedInUserDetail();
        Task<BaseResponse> ForgetPasswordLink(string email);
        Task<BaseResponse> RestForgetPassword(string token, RestPassword RestPassword);
        BaseResponse ValidateForgetPasswordLink(string token);

        Task<ChangePasswordResponse> ChangePassword(ChangePasswordRequest changePasswordRequest);

        UserSearchResultDataResponse SearchByResultByEmail();
        UserSearchResultDataResponse GetReconizeFaceByUserBiometericsId();

        Task<ProfileDetailResponse> GetUserProfileDetail();

        //Task<DMCALegalActionStatusResponse> GetDMCALegalActionStatus(string loggedInUser);

        Task<HitRecordListResponse> GetHitRecords();

        Task<MultipleFaceBiometricsListResponse> GetMultipleFaceBiometricsByHitRecordRecordId(int hitRecordRecordId);
        Task<UserInvoiceListResponse> GetUserInvoice(bool viewAll);

        Task<UserTicketListResponse> GetUserTicket(bool viewAll);

        Task<ImageWithLinksResponse> GetFaceLinks(ImageNameRequest ImageNameRequest);

        Task<BaseResponse> SaveDMCALinks(RemoveableImageLinksRequest removeableImageLinksRequest);

        Task<SavePaymentReponse> SavePaymentDetails(PaymentDetailsRequest paymentDetailsRequest);

        Task<int> SaveDocument(Document documentRequest);
        Task<int> SaveTicketAttachment(TicketAttachment ticketAttachmentRequest);
        Task<int> SaveTickets(TicketRequest ticketRequest);

        Task<DMCALinksResponse> GetDMCARemovalLinks();
        Task<DMCALinksResponse> GetLegalActionRemovalLinks();
        


        Task<BaseResponse> CheckOldPassword(string OldPassword);

        Task<BaseResponse> EmailDMCANotice(DMCANoticeEmailRequest DMCANoticeEmailRequest);

        Task<BaseResponse> EmailLawyerLetter(LawyerLetterEmailRequest lawyerLetterEmailRequest);

        Task<BaseResponse> SaveEnquiry(EnquiryRequest enquiryRequest);

        Task<BaseResponse> UpdatePackage(UpdatePackageRequest updatePackageRequest);

        Task<BaseResponse> DownloadInvoice1(int InvoiceId);
        Task<Stream> DownloadInvoice(int InvoiceId);

        Task<BaseResponse> DeactiveUserStatus();

        Task<IsCurrentUserEmailResponse> IsCurrentUserEmail(string email);

        Task<IsCurrentUserPasswordResponse> IsCurrentUserPassword(string password);

        Task<BaseResponse> StartPlan(StartPlanRequest StartPlanDetails);

        Task<BaseResponse> GenerateDMCANotice(DMCANoticeGenerateRequest DMCAnoticeGenerateRequest);
        Task<PayDMCANoticeList> GetDMCADocuments();

        Task<bool> CheckAccessOnNoticeGenerater();
        Task<CheckUserStatus> CheckStatusOfCurrentUser();

        Task<bool> SendTicketMail(TicketMailRequest TicketMail);

        Task<TaxResponse> GetTax(TaxJarRequest taxJarRequest);
        Task<SignResponse> SignDocument(SignDocumentRequest signDocumentRequest);

        Task<BaseResponse> SaveUpdatedPlan(UpdatePlanRequest updatePlanRequest);

        Task<BaseResponse> SavePayDetail(PayDetailsRequest payDetailsRequest);
        Task<BaseResponse> UpdatePaymentDetail(int paymentId);
        Task<PaymentDetailResponse> GetPaymentDetailByPaymentId(int paymentId);

        Task<BaseResponse> GetUserDetailForSearchInvoked();

    }
}
