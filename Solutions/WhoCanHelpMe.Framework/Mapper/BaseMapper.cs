﻿namespace WhoCanHelpMe.Framework.Mapper
{
    #region Using Directives

    using AutoMapper;

    #endregion

    public abstract class BaseMapper<TInput, TOutput> : IMapper<TInput, TOutput>
    {
        protected BaseMapper()
        {
            this.CreateMap();
        }

        public virtual TOutput MapFrom(TInput input)
        {
            return Mapper.Map<TInput, TOutput>(input);
        }

        protected virtual void CreateMap()
        {
            Mapper.CreateMap<TInput, TOutput>();
        }
    }

    public abstract class BaseMapper<TInput1, TInput2, TOutput> : IMapper<TInput1, TInput2, TOutput>
    {
        protected BaseMapper()
        {
            this.CreateMap();
        }

        public virtual TOutput MapFrom(
            TInput1 input1,
            TInput2 input2)
        {
            var result = Mapper.Map<TInput1, TOutput>(input1);
            Mapper.Map(input2, result);

            return result;
        }

        protected virtual void CreateMap()
        {
            Mapper.CreateMap<TInput1, TOutput>();
            Mapper.CreateMap<TInput2, TOutput>();
        }
    }
}