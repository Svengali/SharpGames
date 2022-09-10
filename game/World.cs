

using System;


namespace game
{


public record Bucket()
{

}



public record World()
{
		public static int ChunkSide = 16;
		public static int ChunkSize = ChunkSide * ChunkSide;

		public record Entity(Pos pos) : Entity<Pos>(pos);

		public class Chunk
		{
			ImmutableArray<Entity> tiles = new();
		}

		public record struct Pos(int x, int y, int z)
		{
			static Pos From(ChunkPos pos) => new Pos(pos.x * ChunkSide, pos.y * ChunkSide, pos.z * ChunkSide);

		}

		public record struct ChunkPos(int x, int y, int z)
		{
			static ChunkPos From(Pos pos) => new ChunkPos(pos.x / ChunkSide, pos.y / ChunkSide, pos.z / ChunkSide);
		}








	}




}