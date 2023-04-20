﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    public class TodosController : ApiController
    {
        private inubeapr2023Entities db = new inubeapr2023Entities();

        // GET: api/Todos
        public IQueryable<todo> Gettodos()
        {
            return db.todos;
        }

        // GET: api/Todos/5
        [ResponseType(typeof(todo))]
        public IHttpActionResult Gettodo(int id)
        {
            todo todo = db.todos.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }

        // PUT: api/Todos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttodo(int id, todo todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != todo.userId)
            {
                return BadRequest();
            }

            db.Entry(todo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!todoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Todos
        [ResponseType(typeof(todo))]
        public IHttpActionResult Posttodo(todo todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.todos.Add(todo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = todo.userId }, todo);
        }

        // DELETE: api/Todos/5
        [ResponseType(typeof(todo))]
        public IHttpActionResult Deletetodo(int id)
        {
            todo todo = db.todos.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            db.todos.Remove(todo);
            db.SaveChanges();

            return Ok(todo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool todoExists(int id)
        {
            return db.todos.Count(e => e.userId == id) > 0;
        }
    }
}