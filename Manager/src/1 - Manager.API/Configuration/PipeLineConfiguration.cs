namespace Manager.API.Configuration
{

    public static class PipeLineConfiguration
    {
        public static void AddPipeLineConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {          
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

        }        
    
    }
    
}