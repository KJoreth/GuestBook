namespace GuestBook.Controllers
{
    public class EntryController : Controller
    {
        private readonly IEntryHandler _entryHandler;
        private readonly IPaginationHandler _paginationHandler;


        public EntryController(IEntryHandler entryHandler, IPaginationHandler paginationHandler)
        {
            _entryHandler = entryHandler;
            _paginationHandler = paginationHandler;
        }


        [HttpGet]
        public IActionResult Show(int id = 1)
        {
            return View(_paginationHandler.GetEntriesForPage(id));
        }

        [HttpPost]
        public IActionResult ShowPost(int CurrentPageIndex)
        {
            return RedirectToAction("Show", "Entry", new { id = CurrentPageIndex });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EntryCreateDTO entry)
        {
            if (ModelState.IsValid)
            {
                _entryHandler.AddEntry(entry);
                ModelState.Clear();
                ViewBag.Msg = "Your entry have been submited";
                return View();
            }

            ViewBag.Msg = "An error accured. Your entry have not been submited";
            return View();
        }

    }
}
