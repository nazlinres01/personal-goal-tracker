using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalGoalTrackerAPI.Models;
using PersonalGoalTrackerAPI.Services;
using PersonalGoalTrackerAPI.DTOs;

namespace PersonalGoalTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoalsController : ControllerBase
    {
        private readonly IGoalService _goalService;

        public GoalsController(IGoalService goalService)
        {
            _goalService = goalService;
        }

        // GET: api/goals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoalDto>>> GetAllGoals()
        {
            var goals = await _goalService.GetAllGoalsAsync();
            return Ok(goals);
        }

        // GET: api/goals/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GoalDto>> GetGoalById(int id)
        {
            var goal = await _goalService.GetGoalByIdAsync(id);

            if (goal == null)
            {
                return NotFound();
            }

            return Ok(goal);
        }

        // POST: api/goals
        [HttpPost]
        public async Task<ActionResult<GoalDto>> CreateGoal([FromBody] GoalDto goalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdGoal = await _goalService.AddGoalAsync(goalDto);
            return CreatedAtAction(nameof(GetGoalById), new { id = createdGoal.Id }, createdGoal);
        }

        // PUT: api/goals/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGoal(int id, [FromBody] GoalDto goalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedGoal = await _goalService.UpdateGoalAsync(id, goalDto);

            if (updatedGoal == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/goals/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoal(int id)
        {
            var deleted = await _goalService.DeleteGoalAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
