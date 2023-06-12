using System.Reflection.Metadata;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Subcategory> Subcategories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Otp> Otps { get; set; }
    public DbSet<DocumentEntity> Documents { get; set; }
    public DbSet<Reply> Replies { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<SubcategoryVideo> SubcategoryVideos { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<DocumentTemplate> DocumentTemplates { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubcategoryVideo>()
            .HasKey(sc => new { sc.SubcategoryId, sc.VideoId });

        modelBuilder.Entity<SubcategoryVideo>()
            .HasOne(sc => sc.Subcategory)
            .WithMany(s => s.SubcategoryVideos)
            .HasForeignKey(sc => sc.SubcategoryId);

        modelBuilder.Entity<SubcategoryVideo>()
            .HasOne(sc => sc.Video)
            .WithMany(v => v.SubcategoryVideos)
            .HasForeignKey(sc => sc.VideoId);

        modelBuilder.Entity<Reply>()
            .HasOne(r => r.User)
            .WithMany(u => u.Replies)
            .OnDelete(DeleteBehavior.Restrict);
        ;

        modelBuilder.Entity<Reply>()
            .HasOne(r => r.Comment)
            .WithMany(c => c.Replies)
            .OnDelete(DeleteBehavior.Cascade);
        ;
        modelBuilder.Entity<Vote>()
            .HasOne(v => v.User)
            .WithMany(u => u.Votes)
            .OnDelete(DeleteBehavior.Restrict);

        Guid ugolovnoeDeloId = Guid.NewGuid();
        Guid grazhdanskoeDeloId = Guid.NewGuid();
        Guid administrativnoeDeloId = Guid.NewGuid();

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = ugolovnoeDeloId,
                Name = "Уголовное дело",
                Slug = "ugolovnoe-delo",
                Description =
                    "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.",
                FullDescription =
                    "Категория \"Уголовное дело\" на нашем юридическом сайте представляет собой центральную точку для всех, кто ищет надежную поддержку и консультации в разбирательствах с законом. Уголовное дело охватывает широкий спектр правовых вопросов, связанных с преступлениями, обвинениями и уголовным правосудием.\n\nНаша команда опытных юристов специализируется на уголовном праве и готова предложить вам профессиональную помощь во всех аспектах уголовного дела. Мы понимаем, что столкнуться с уголовным обвинением или стать свидетелем преступления может быть эмоционально и юридически сложным процессом. Поэтому мы стремимся обеспечить наших клиентов всесторонней поддержкой и уверенностью в достижении наилучших результатов.\n\nВ категории \"Уголовное дело\" вы найдете информацию о различных видов уголовных преступлений, их юридическом определении и последствиях. Мы предлагаем подробные обзоры основных составов преступлений, включая убийство, грабеж, насилие, кражу и другие. Каждый тип преступления раскрывается с точки зрения законодательства, а также рассматриваются особенности расследования и судебного процесса, связанные с этими делами.\n\nКроме того, в рамках категории \"Уголовное дело\" мы предоставляем информацию о правовых аспектах уголовного правосудия. Вы найдете полезные статьи о процессе уголовного расследования, оформлении обвинительного акта, правах обвиняемых и защите прав потерпевших. Мы также рассматриваем вопросы, связанные с уголовной ответственностью, наказаниями, судебными процессами и альтернативными способами урегулирования уголовных дел.\n\nНаша команда юристов имеет богатый опыт работы с клиентами, которые столкнулись с уголовными делами. Мы стремимся предоставить вам всю необходимую информацию и руководство, чтобы помочь вам принять обоснованные решения в сложных юридических ситуациях. Мы понимаем, что каждое уголовное дело уникально, и поэтому наш подход к каждому клиенту индивидуален и внимателен.\n\nЕсли вы ищете помощь в уголовном деле, не стесняйтесь обратиться к нам. Мы готовы предоставить вам профессиональную консультацию, представлять вас в суде и работать над достижением наилучших результатов в вашем уголовном деле.\n\nМы верим, что каждый имеет право на справедливое и справедливое уголовное правосудие. Мы нацелены на защиту ваших прав и интересов, и мы готовы помочь вам преодолеть сложности уголовного дела.\n\nОбратитесь к нам уже сегодня и дайте нам возможность стать вашим надежным партнером в уголовном праве.",
                ImageUrl =
                    "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlMedium =
                    "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlSmall =
                    "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80"
            },
            new Category
            {
                Id = grazhdanskoeDeloId,
                Name = "Гражданское дело",
                Slug = "grazhdanskoe-delo",
                Description =
                    "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.",
                FullDescription =
                    "Гражданское дело - это область юридической практики, которая занимается регулированием отношений между физическими и юридическими лицами. Оно охватывает широкий спектр вопросов, связанных с гражданскими правами и обязанностями, собственностью, контрактами, наследством, семейными спорами, трудовыми отношениями и многим другим.\n\nВ рамках гражданского дела наша команда юристов предоставляет комплексные юридические услуги для решения различных гражданских проблем. Мы осознаем, что столкнуться с гражданским спором или необходимостью защищать свои права может быть сложным и запутанным процессом. Поэтому мы стремимся обеспечить нашим клиентам профессиональное сопровождение и решение важных правовых вопросов.\n\nНаша команда специализируется на различных аспектах гражданского права, включая судебные споры, составление и анализ юридических документов, юридическое консультирование и представительство интересов клиентов перед судом и другими органами. Мы уделяем особое внимание каждому делу и стремимся найти оптимальное решение, которое удовлетворит интересы наших клиентов.\n\nВ рамках категории \"Гражданское дело\" вы найдете информацию о различных аспектах гражданского права. Мы предлагаем подробные обзоры основных видов гражданских дел, таких как договорные споры, споры о собственности, наследственные споры, разводы, алименты, трудовые споры и многие другие. Кроме того, мы предоставляем информацию о правовых нормах, прецедентах, судебной практике и возможных способах разрешения гражданских споров.\n\nНаша цель - помочь нашим клиентам разобраться в сложностях гражданского дела и достичь желаемых результатов. Мы прилагаем все усилия, чтобы предоставить профессиональные услуги, индивидуальный подход и компетентное сопровождение в каждом конкретном случае.\n\nЕсли у вас возникли гражданские проблемы или вам нужна правовая поддержка, обратитесь к нам. Наша команда юристов готова помочь вам в решении гражданских споров, предоставить консультацию и оказать необходимую правовую помощь.\n\nДоверьте свои гражданские дела профессионалам и получите надежное юридическое сопровождение для достижения желаемых результатов.",
                ImageUrl =
                    "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                ImageUrlMedium =
                    "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                ImageUrlSmall =
                    "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
            },
            new Category
            {
                Id = administrativnoeDeloId,
                Name = "Административное дело",
                Slug = "administrativnoe-delo",
                Description =
                    "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.",
                FullDescription =
                    "Административное дело - это область юридической практики, которая занимается регулированием правовых вопросов, связанных с административными правонарушениями и процедурами, установленными административным правом. В административном праве регулируются отношения между гражданами и государством, а также между государственными органами.\n\nВ рамках категории \"Административное дело\" наша команда юристов предоставляет специализированные юридические услуги в области административного права. Мы имеем опыт работы с клиентами, столкнувшимися с различными административными правонарушениями, и готовы оказать профессиональную помощь в решении сложных правовых вопросов.\n\nМы понимаем, что административные правонарушения могут иметь серьезные последствия для наших клиентов, включая штрафы, лишение прав, конфискацию имущества и другие негативные последствия. Поэтому мы стремимся предоставить нашим клиентам качественное представительство и юридическую помощь, чтобы защитить их интересы и обеспечить справедливое решение дела.\n\nВ рамках категории \"Административное дело\" мы предлагаем широкий спектр услуг. Наша команда специализируется на оказании правовой помощи в случаях нарушений правил дорожного движения, административных правонарушений в сфере налогообложения, нарушениях трудового законодательства, противодействии коррупции и других административных правонарушениях.\n\nМы готовы представлять интересы клиентов перед административными органами, судами и другими государственными инстанциями. Наша команда знакома с процедурами и требованиями, связанными с административным делопроизводством, и готова оказать профессиональное сопровождение и представительство в каждом конкретном случае.\n\nМы осознаем важность своей роли в защите прав и интересов наших клиентов в административном процессе. Мы стремимся к достижению наилучших результатов для наших клиентов, обеспечивая правовую защиту и представительство на самом высоком уровне.\n\nЕсли у вас возникли административные проблемы, не стесняйтесь обратиться к нам. Наша команда юристов готова предоставить вам квалифицированную юридическую помощь и сопровождение, чтобы помочь вам решить ваше административное дело.",
                ImageUrl =
                    "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlMedium =
                    "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
                ImageUrlSmall =
                    "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80"
            }
        );
        Guid ubiystvoId = Guid.NewGuid();
        Guid videoId = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = ubiystvoId,
                CategoryId = ugolovnoeDeloId,
                Name = "Убийство",
                Slug = "ubiystvo",
                Description = "Описание убийства",
                FullDescription =
                    "Статья 99 Уголовного кодекса Республики Казахстан регулирует уголовную ответственность за убийство, определяя его как противоправное умышленное причинение смерти другому человеку. Согласно этой статье, убийство наказывается лишением свободы на срок от восьми до пятнадцати лет.\n\nОднако, статья 99 также учитывает различные обстоятельства и мотивы, которые могут усилить наказание за убийство. Это включает убийство двух или более лиц; убийство лица или его близких в связи с осуществлением данным лицом служебной деятельности или выполнением профессионального или общественного долга; убийство лица, заведомо для виновного находящегося в беспомощном состоянии, а равно сопряженное с похищением человека либо захватом заложника; убийство женщины, заведомо для виновного находящейся в состоянии беременности; убийство, совершенное с особой жестокостью или способом, опасным для жизни других людей; убийство, совершенное группой лиц, группой лиц по предварительному сговору; убийство из корыстных побуждений, а равно по найму либо сопряженное с разбоем или вымогательством; убийство из хулиганских побуждений; убийство, совершенное с целью скрыть другое преступление или облегчить его совершение, а равно сопряженное с изнасилованием или насильственными действиями сексуального характера; убийство по мотиву социальной, национальной, расовой, религиозной ненависти или вражды либо кровной мести; убийство, совершенное с целью использования органов или тканей потерпевшего; убийство, совершенное неоднократно; убийство заведомо несовершеннолетнего лица; убийство, совершенное преступной группой, а равно в условиях чрезвычайной ситуации или в ходе мОписание (продолжение):\n\nассовых беспорядков. Все эти обстоятельства могут привести к увеличению наказания до лишения свободы на срок от пятнадцати до двадцати лет, пожизненного лишения свободы, с конфискацией имущества или без таковой.\n\nОсобо отмечается убийство малолетнего лица, которое наказывается лишением свободы сроком на двадцать лет с пожизненным лишением права занимать определенные должности или заниматься определенной деятельностью либо пожизненным лишением свободы с конфискацией имущества или без таковой.\n\nСтатья 99 Уголовного кодекса РК была изменена и дополнена законами РК от 07.11.2014 \u2116 248-V (вводится в действие с 01.01.2015) и от 27.12.2019 \u2116 292-VІ.\n\nВажно отметить, что информация, представленная в данном описании, является общей и не заменяет юридическую консультацию. Если у вас есть вопросы или проблемы, связанные с уголовным правом, рекомендуется обратиться к квалифицированному юристу или специалисту по уголовному праву.",
                Image =
                    "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                Content = "Краткое описание состава убийства и особенности расследования таких дел",
                MetaTitle = "Убийство: Категория уголовного дела и особенности расследования",
                MetaKeywords = "убийство, уголовное дело, расследование, уголовное право",
                MetaDescription =
                    "Описание убийства в контексте уголовного дела: состав, особенности расследования и подробности события",
            }
        );
        modelBuilder.Entity<Video>().HasData(
            new
            {
                Id = videoId,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Title = "Описание состава убийства movie",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        modelBuilder.Entity<SubcategoryVideo>().HasData(
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoId,
                VideoId = videoId,
            }
        );
        Guid ubiystvoponeostorozhnostiId = Guid.NewGuid();
        Guid video1Id = Guid.NewGuid();
        Guid video2Id = Guid.NewGuid();
        modelBuilder.Entity<Subcategory>().HasData(
            new Subcategory
            {
                Id = ubiystvoponeostorozhnostiId,
                CategoryId = ugolovnoeDeloId,
                Name = "Убийство по неосторожности",
                Slug = "ubiystvo-po-neostorozhnosti",
                Description = "Описание убийства по неосторожности",
                FullDescription =
                    "\"Причинение смерти по неосторожности\" - это серьезное уголовное правонарушение, которое описано в статье 104 Уголовного кодекса Республики Казахстан. Это преступление включает в себя действия или бездействия, которые приводят к смерти другого человека без умысла на лишение жизни.\n\nСогласно законодательству, причинение смерти по неосторожности наказывается ограничением свободы на срок до трех лет либо лишением свободы на тот же срок. Если же смерть по неосторожности причинена двум или более лицам, наказание увеличивается до ограничения свободы на срок до пяти лет либо лишением свободы на тот же срок.\n\nПричинение смерти по неосторожности отличается от умышленного убийства тем, что виновное лицо не намеревалось лишить жизни другого человека. Вместо этого, смерть является неожиданным и непреднамеренным результатом действий или бездействия виновного лица. Это может произойти, например, в результате небрежного обращения с огнем или огнестрельным оружием.\n\nСубъектом преступления может быть любое лицо, достигшее 16-летнего возраста. Объективная сторона преступления включает в себя действия или бездействия, которые нарушают правила предосторожности и приводят к смерти другого человека. Это может произойти в любой сфере жизни, включая быт, спорт, хозяйственную или производственную деятельность, медицинскую деятельность и научно-техническую деятельность.\n\nСубъективная сторона преступления включает в себя вину по причине собственной неосторожности, которая проявляется в легкомыслии или небрежности. Виновное лицо могло предвидеть возможность наступления смерти в ходе своих действий, но без достаточных оснований самонадеянно рассчитывало на ее предотвращение.\n\nВажно отметить, что для установления вины в причинении смерти по неосторожности необходимо доказать причинно-следственную связь междду действиями (или бездействием) виновного лица и наступившей смертью. Это означает, что смерть должна быть прямым и предсказуемым результатом действий виновного лица.\n\nПричинение смерти по неосторожности часто встречается в быту, спорте, хозяйственной или производственной деятельности, медицинской деятельности, научно-технической деятельности. Этот вид преступления всегда связан с нарушением правил предосторожности, будь то общечеловеческие или общеобязательные, в том числе меры осмотрительности или правила в определенной сфере деятельности.\n\nВажно отметить, что причинение смерти по неосторожности следует отличать от невиновного причинения смерти, когда лицо не предвидит возможность наступления смерти в ходе своих действий и по обстоятельствам не могло их предотвратить.\n\nВиновное лицо может пренебрегать определенными правилами, не соблюдать их или допустить их грубое нарушение. Такие требования могут не быть выполнены должным образом из-за личной невнимательности, неосмотрительности и недостаточной социальной адаптации виновного лица.\n\nВ случае, когда лицо не предвидит возможность наступления смертельного исхода в ходе своих действий (или бездействия), но при необходимой внимательности и осмотрительности должно было это предвидеть, преступление признается совершенным в результате небрежности.\n\nВ общем, причинение смерти по неосторожности - это серьезное преступление, которое требует тщательного рассмотрения и анализа обстоятельств, ведущих к смертельному исходу. Это преступление имеет глубокие последствия как для виновного лица, так и для семьи и близких умершего, и поэтому оно должно быть тщательно расследовано и наказано в соответствии с законом.",
                Image =
                    "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                Content = "Краткое описание состава убийства по неосторожности и особенности расследования таких дел",
                MetaTitle = "Убийство по неосторожности: Категория уголовного дела и расследование",
                MetaKeywords = "убийство по неосторожности, уголовное дело, расследование, уголовное право",
                MetaDescription =
                    "Описание убийства по неосторожности в контексте уголовного дела: состав, особенности расследования и подробности события"
            }
        );
        modelBuilder.Entity<Video>().HasData(
            new
            {
                Id = video1Id,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Title = "Причинение смерти по неосторожности правонарушение1 movie",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            },
            new
            {
                Id = video2Id,
                SubcategoryId = ubiystvoId,
                Url = "https://youtu.be/AmUenqhE1mw",
                Title = "Причинение смерти по неосторожности правонарушение2 movie",
                Description =
                    "<div class='App' style='text-align: center;'>" +
                    "<h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p>" +
                    "<p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p>" +
                    "<hr class='remove'></div>"
            }
        );
        modelBuilder.Entity<SubcategoryVideo>().HasData(
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoponeostorozhnostiId,
                VideoId = video1Id,
            },
            new SubcategoryVideo
            {
                SubcategoryId = ubiystvoponeostorozhnostiId,
                VideoId = video2Id,
            }
        );
        modelBuilder.Entity<Role>().HasData(new Role
        {
            RoleId = 1,
            RoleName = RoleName.SuperAdmin,
        }, new Role
        {
            RoleId = 2,
            RoleName = RoleName.Admin,
        }, new Role
        {
            RoleId = 3,
            RoleName = RoleName.Moderator,
        }, new Role
        {
            RoleId = 4,
            RoleName = RoleName.Basic,
        });
    }
}