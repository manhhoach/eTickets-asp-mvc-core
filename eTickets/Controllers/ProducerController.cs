//using eTickets.Models;
//using eTickets.Services.Producer;
//using Microsoft.AspNetCore.Mvc;

//namespace eTickets.Controllers
//{
//    public class ProducerController : Controller
//    {
//        private readonly IProducerService _producerService;
//        public ProducerController(IProducerService producerService)
//        {
//            _producerService = producerService;
//        }
//        public async Task<IActionResult> Index()
//        {
//            var data = await _producerService.GetAll();
//            return View(data);
//        }
//        public IActionResult Create()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> Create(Producer data)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(data);
//            }
//            await _producerService.Add(data);
//            return RedirectToAction("Index");

//        }
//        public async Task<IActionResult> Details(int id)
//        {
//            Producer data = await _producerService.GetById(id);
//            if (data != null)
//                return View(data);
//            return View("NotFound");
//        }
//        public async Task<IActionResult> Edit(int id)
//        {
//            Producer data = await _producerService.GetById(id);
//            if (data == null)
//            {
//                return View("NotFound");
//            }
//            return View(data);

//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(int id, Producer data)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(data);
//            }
//            await _producerService.Update(id, data);
//            return RedirectToAction(nameof(Index));

//        }

//        public async Task<IActionResult> Delete(int id)
//        {
//            Producer data = await _producerService.GetById(id);
//            if (data == null)
//            {
//                return View("NotFound");
//            }
//            return View(data);

//        }
//        [HttpPost, ActionName("Delete")]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            await _producerService.Delete(id);
//            return RedirectToAction(nameof(Index));

//        }
//    }
//}
