using APP_LAWYER.BLL.Repositories;
using APP_LAWYER.DAL.Data;

namespace APP_LAWYER.BLL;

public class UOW
{
    private readonly AppDbContext _db;

    private CategoriRepository _categoriRepository;
    private CommentRepository _commentRepository;
    private DocumentRepository _documentRepository;
    public DocumentTemplateRepository _documentTemplateRepository;
    private OtpRepository _otpRepository;
    private ReplyRepository _replyRepository;
    public RoleRepository _roleRepository;
    private SubcategoryRepository _subcategoryRepository;
    private SubcategoryVideoRepository _subcategoryVideoRepository;
    private UserRepository _userRepository;
    private VideoRepository _videoRepository;
    private VoteRepository _voteRepository;

    public UOW(AppDbContext db)
    {
        _db = db;
    }

    public CategoriRepository CategoriRepository
    {
        get
        {
            if (_categoriRepository == null) _categoriRepository = new CategoriRepository(_db);
            return _categoriRepository;
        }
    }

    public SubcategoryRepository SubcategoryRepository
    {
        get
        {
            if (_subcategoryRepository == null) _subcategoryRepository = new SubcategoryRepository(_db);
            return _subcategoryRepository;
        }
    }

    public CommentRepository CommentRepository
    {
        get
        {
            if (_commentRepository == null) _commentRepository = new CommentRepository(_db);
            return _commentRepository;
        }
    }

    public DocumentRepository DocumentRepository
    {
        get
        {
            if (_documentRepository == null) _documentRepository = new DocumentRepository(_db);
            return _documentRepository;
        }
    }

    public UserRepository UserRepository
    {
        get
        {
            if (_userRepository == null) _userRepository = new UserRepository(_db);
            return _userRepository;
        }
    }

    public ReplyRepository ReplyRepository
    {
        get
        {
            if (_replyRepository == null) _replyRepository = new ReplyRepository(_db);
            return _replyRepository;
        }
    }

    public VoteRepository VoteRepository
    {
        get
        {
            if (_voteRepository == null) _voteRepository = new VoteRepository(_db);
            return _voteRepository;
        }
    }

    public OtpRepository OtpRepository
    {
        get
        {
            if (_otpRepository == null) _otpRepository = new OtpRepository(_db);
            return _otpRepository;
        }
    }

    public SubcategoryVideoRepository SubcategoryVideoRepository
    {
        get
        {
            if (_subcategoryVideoRepository == null) _subcategoryVideoRepository = new SubcategoryVideoRepository(_db);
            return _subcategoryVideoRepository;
        }
    }

    public VideoRepository VideoRepository
    {
        get
        {
            if (_videoRepository == null) _videoRepository = new VideoRepository(_db);
            return _videoRepository;
        }
    }

    public RoleRepository RoleRepository
    {
        get
        {
            if (_roleRepository == null) _roleRepository = new RoleRepository(_db);
            return _roleRepository;
        }
    }

    public DocumentTemplateRepository DocumentTemplateRepository
    {
        get
        {
            if (_documentTemplateRepository == null) _documentTemplateRepository = new DocumentTemplateRepository(_db);
            return _documentTemplateRepository;
        }
    }
}